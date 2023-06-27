namespace Oops
{
    public sealed class SingleTonObj
    {
        private static readonly SingleTonObj instance = new SingleTonObj();

        static SingleTonObj() {

            Console.WriteLine("static");

        }
        
        private SingleTonObj() { Console.WriteLine("private"); }

        public static SingleTonObj Instance
        {
            get
            {
                return instance;
            }
        }
    }


 
}