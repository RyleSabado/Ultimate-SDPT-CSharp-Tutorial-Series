using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 16: Constructors | N
    internal class Constructors
    {
        //Constructors: methods named after the class name
        public static void ConstructorsLesson()
        {
            /*
            Product p = new Product("Milk", 150);
            Console.WriteLine(p.name);
            */
            Console.Write("Enter Character Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Voiceline: ");
            string voiceline = Console.ReadLine();
            Character c = new Character(name, voiceline);
        }
    }
    /*
    class Product
    {
        public string name;
        public float price;
        //Constructors must have public access type, there must be no return type
        //Trick: in order to generate quick contructor, point your mouse then click "generate constructor"
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
            Console.WriteLine("Product Created");
            Console.WriteLine(name + " " + price);
        }
        

    }
    */
    //Challenge
    class Character
    {
        public string name;
        public string voiceline;

        public Character(string name, string voiceline)
        {
            this.name = name;
            this.voiceline = voiceline;

            Console.WriteLine(name + ":" + voiceline);
        }
    }
}
