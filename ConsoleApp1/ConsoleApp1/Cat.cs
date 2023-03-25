using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat : Animal, IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat Mice");
            Console.WriteLine("So {0} who is colour {1} and is {2} years old eats mice", Name, Colour, Age);
        }

        public Cat()
        { }

        public List<IAnimal> Puss;
        public Cat(string name, string colour, double height, int age) : base(name, colour, height, age)
        {
            Puss = new List<IAnimal>();
        }
        public void Eat1()
        {
            Console.WriteLine("I Eat Meat");
        }

        public void Cry()
        {
            Console.WriteLine("Meow");
        }

    }
}
