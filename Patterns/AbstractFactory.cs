using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class AbstractFactory
    {
    }

    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }


    public interface IProductA { }
    public interface IProductB { }


    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }


        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }


    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }


        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


    public class ProductA1 : IProductA { }
    public class ProductB1 : IProductB { }
    public class ProductA2 : IProductA { }
    public class ProductB2 : IProductB { }


    public class Client
    {
        private readonly IProductA _productA;
        private readonly IProductB _productB;


        public Client(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }

}
