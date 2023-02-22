using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 22: Abstraction | U
    internal class Abstraction
    {
        public static void AbstractionLesson()
        {
            AnimalX d = new DogX("Scobby", 1, "askal");
            AnimalX c = new CatX("Muning", 2);
            d.makeSound();
            c.makeSound();
        }
    }
    abstract class AnimalX //You can instantiate abstract classes (7:08)
        //abstract classes eliminate illogical ideas(11:28)
    {
        //forces derived classes to makesound(10:12)
        //only abstract methods has no body(10:42)
        string name { get; set; }
        int age { get; set; }

        public AnimalX(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void makeSound(); 
        public void sleep()
        {
            Console.WriteLine("ZzzzzZ");
        }
    }
    class DogX : AnimalX
    {
        public string breed { get; set; }
        public DogX(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }

        public override void makeSound()
        {
            //arf
            Console.WriteLine("Arf");
        }
    }
    class CatX : AnimalX 
    {
        public CatX(string name, int age) : base(name, age)
        {
        }

        public override void makeSound() 
        {
            //meow
            Console.WriteLine("meow");
        } 
    }
}
