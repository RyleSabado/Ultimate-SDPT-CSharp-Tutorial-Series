using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 23: Interfaces | V
    internal class Interfaces
    {
        public static void InterfacesLesson()
        {
            //Intantiating Interfaces(13:49)
            //DONT USE INTERFACES WHEN INTANTIATING, YOU DUMBASS (16:07)
            IAnimal d = new IDog();
            ILandAnimal dd = new IDog();
            IAnimal b = new IBird();
            ILandAnimal bb = new IBird();
            IAirAnimal bbb = new IBird();

            /////
            IDog d1 = new IDog();
            d1.walk();


        }
    }
    //Interface: all methods implemental inside an interface class are abstract by default
    //variables are not allowed inside an interface class
    interface IAnimal
    {
        void makesound();
    }

    interface ILandAnimal
    {
        void walk();
    }
    interface IAirAnimal : ILandAnimal //You can inherit interfaces
    {
        void fly();
    }
    class IDog : IAnimal, ILandAnimal //You can implemental multiple interfaces but not inheritance (11:10)
    {
        public void makesound() //you dont have to put override on interfaces(10:00), but it needs to be public
        {
            Console.WriteLine("Arf");
        }
        public void walk()
        {
            Console.WriteLine("Dog is walking");
        }
    }
    class IBird : IAnimal, IAirAnimal
    {
        public void makesound()
        {
            Console.WriteLine("Meow");
        }
        public void walk()
        {
            Console.WriteLine("Bird is walking");
        }
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
