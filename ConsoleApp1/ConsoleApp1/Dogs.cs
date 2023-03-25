using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dogs : Animal ,IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
            Console.WriteLine("So {0} who is colour {1} and is {2} years old eats Meat", Name, Colour, Age);
        }

        public List<IAnimal> Dawg;
        public Dogs() { }
        public Dogs(string name, string colour, double height, int age) :base(name,colour, height, age)
        {
            Dawg = new List<IAnimal>();
        }
        public void Eat1()
        {
            Console.WriteLine("I Eat Meat");
        }

        public void Cry()
        {
            Console.WriteLine("Woof");
        }

    }
}
