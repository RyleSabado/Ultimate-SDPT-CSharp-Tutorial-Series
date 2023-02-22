using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 21: Polymorphism | T
    internal class Polymorphism
    {
        public static void PolymorphismLesson()
        {
            //you can instantiate the derived class from the base class(4:06)
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();
            d.makeSound();
            c.makeSound();
            
            
        }
    }
    class Animal
    {
        //Virtual modifier(9:56): used to override properties from the base class
        virtual public void makeSound()
        {
            //sound
            Console.WriteLine("Override this");
        }
    }
    class Dog : Animal
    {
        //Override Modifier(10:47): comes along with virtual modifier
        override public void makeSound()
        {
            //arf
            Console.WriteLine("Arf");
        }
    }
    class Cat : Animal
    {
        override public void makeSound()
        {
            //meow
            Console.WriteLine("Neow");
        }
    }
}
