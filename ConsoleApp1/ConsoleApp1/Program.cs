using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Jelly", "Brown", 5.7,1);
            cat.Eat();
            Animal dog = new Dogs("Sunny", "Black",6.0,2);
            dog.Eat();

            Dogs dog1 = new Dogs("sunny", "black", 5.7, 4);
            dog1.Dawg.Add(dog1);
            foreach (Dogs dogs in dog1.Dawg)
            {
                Console.WriteLine("{0} is hungry so he", dog1.Name);
            }
            dog1.Cry();
            dog1.Eat();
            Cat cat1 = new Cat("Luna", "Grey", 6.0, 3);
            cat1.Puss.Add(cat1);
            foreach (Cat cats in cat1.Puss)
            {
                Console.WriteLine("{0} is hungry so she", cat1.Name);
            }
            cat1.Cry();
            cat1.Eat();
            Console.WriteLine(cat1.ToString());
            Console.WriteLine(dog1.ToString());



            Cat cat2 = new Cat();
            Console.WriteLine("Enter Name: ");
            string inputname = Console.ReadLine();
            cat2.Name = inputname;
            Console.WriteLine("Enter Age: ");
            string inputAge = Console.ReadLine();
            int convert1 = int.Parse(inputAge);
            cat2.Age = convert1;
            Console.WriteLine("Enter Color: ");
            string inputColor = Console.ReadLine();
            cat2.Colour = inputColor;
            Console.WriteLine("Enter Height: ");
            string inputHeight = Console.ReadLine();
            double convert2 = double.Parse(inputHeight);
            cat2.Height = convert2;

            Console.WriteLine("Name: {0} AGE: {1} Height: {2} Colour: {3}",cat2.Name,cat2.Age,cat2.Height,cat2.Colour);

            Dogs dog2 = new Dogs();
            Console.WriteLine("Enter Name: ");
            string inputname1 = Console.ReadLine();
            dog2.Name = inputname1;
            Console.WriteLine("Enter Age: ");
            string inputAge1 = Console.ReadLine();
            int convert11 = int.Parse(inputAge1);
            dog2.Age = convert11;
            Console.WriteLine("Enter Color: ");
            string inputColor1 = Console.ReadLine();
            dog2.Colour = inputColor1;
            Console.WriteLine("Enter Height: ");
            string inputHeight1 = Console.ReadLine();
            double convert21 = double.Parse(inputHeight1);
            dog2.Height = convert21;

            Console.WriteLine("Name: {0} AGE: {1} Height: {2} Colour: {3}", dog2.Name, dog2.Age, dog2.Height, dog2.Colour);
        }
    }
}
