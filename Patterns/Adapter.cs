using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Patterns
{


    public class ExistingImplementation
    {
        public XmlDocument processScore()
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<student>" + 
                        "  <score>440</score>" +
                        "</student>");
            return doc;
            //return (new Random().Next());
        }
    }

    public class NewImplementationAdapter: INewImplementation
    {
        private readonly ExistingImplementation _existingImplementation;
        public NewImplementationAdapter(ExistingImplementation existingImplementation)
        {
            _existingImplementation = existingImplementation;
        }
        public string New_processScore()
        {
            string newResponse =
                JsonConvert.SerializeXmlNode(_existingImplementation.processScore());
            return newResponse;
        }
    }


    public interface INewImplementation {
        string New_processScore();
    }
}
