using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class Oops
    {

    }

    public interface ISwim
    {
        void Swim();
    }

    interface IFly
    {
        void Fly();
    }



    public abstract class Animal
    {

        public void Breath()
        {
            Console.WriteLine("Animal : Breath");
        }
        public void Eat()
        {
            Console.WriteLine("Animal : Eat");
        }
        public void Sleep()
        {
            Console.WriteLine("Animal : Sleep");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal : MakeSound");
        }

        public abstract void LivesIn();
    }

    public abstract class Bird : Animal
    {



        //public override void LivesIn()
        //{
        //    Console.WriteLine("Bird : Tree");
        //}
    }

    public class Dog : Animal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Dog : Swim");
        }

        public override void LivesIn()
        {
            Console.WriteLine("Dog : Land");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog : MakeSound Bark");
        }
    }

    public class Duck : Bird, ISwim, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Bird : Fly");
        }

        public void Swim()
        {
            Console.WriteLine("Bird : Swim");
        }
        public override void LivesIn()
        {
            Console.WriteLine("Bird : Tree Land Water");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Duck : MakeSound Quack");
        }
    }

    public class Planet
    {

        //static Planet() {
        //    Console.WriteLine("static ctor");
        //}
        //private Planet()
        //{
        //    Console.WriteLine("private ctor");
        //}

        //public Planet(int size)
        //{
        //    Console.WriteLine("public ctor");
        //}

        public virtual void Colour()
        {
            Console.WriteLine("Base Planet: Color");
        }

        public void Size()
        {
            Console.WriteLine("Base Planet: Size");
        }
    }

    public class RouguePlanet : Planet
    {
        public override void Colour()
        {
            Console.WriteLine("Rougue: Color");
        }

        public void Size()
        {
            Console.WriteLine("Rougue: Size: default");
        }

        public void Size(int diameter)
        {
            Console.WriteLine("Rougue: Size: " + diameter);
        }
    }

    public class PlanetCTOR
    {

        static PlanetCTOR()
        {
            Console.WriteLine("static ctor");
        }
        //private PlanetCTOR()
        //{
        //    Console.WriteLine("private ctor");
        //}

        public PlanetCTOR()
        {
            Console.WriteLine("public ctor");
        }
        //public PlanetCTOR(int size)
        //{
        //    Console.WriteLine("public ctor param");
        //}
    }
}
