using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public string name;
        public string colour;
        public int age;
        public double height;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }   
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public Animal() { }
        public Animal(string name, string colour, double height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            this.Height = height;
        }

        public virtual void Eat() {}

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Colour: " + Colour + " Height: " + Height;
        }
    }
}
