using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{

    //Episode 20: Inheritance | S
    /*
    //Without Constructors
    internal class Inheritance
    {
        public static void InheritanceLesson()
        {
            PersonX p = new PersonX();
            p.name = "Ryle";
            p.sex = "F";
            p.age = 1000;
            Toddler t = new Toddler();
            t.name = "Gideon";
            p.sex = "M";
            p.age = 50;
        }
    }
    //modifiers class derivedclassname : baseclassname {}
    //Base Class
    class PersonX
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        public void introduceSelf()
        {
            Console.WriteLine("I am "+ name);
        }
    }
    //Derived Class
    class Toddler : PersonX
    {
    }
    */
    /*
    //With Constructors(12:39)
    internal class Inheritance
    {
        public static void InheritanceLesson()
        {
            PersonX p = new PersonX("Ryle", "F", 1000);
            p.introduceself();
            Toddler t = new Toddler("Gideon", "M", 50, "fistfights");
            t.introduceself();

        }
    }
    //modifiers class derivedclassname : baseclassname {}
    //Base Class
    class PersonX
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        public PersonX(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        //Overriding Methods(26:05)
        public void introduceself()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("Age: " + age);
        }
    }
    //Derived Class
    class Toddler : PersonX
    {
        public string game { get; set; }
        //base keyword can only be used by derived class
        //you can also add other arguments on derived class, ex game
        public Toddler(string name, string sex, int age, string game) : base(name, sex, age)
        {
            this.game = game;
        }
        //Overriding Methods(26:05)
        public void introduceself()
        {
            base.introduceself();
            Console.WriteLine("Favorite Game: " + game);
        }
    }
    */
    //Game Concept
    internal class Inheritance
    {
        public static void InheritanceLesson()
        {
            BasicEnemy be = new BasicEnemy("Troll", 100, 100);
            be.attack();
            be.walk();
            be.die();
            FlyingEnemy fe = new FlyingEnemy("Birb", 100, 100);
            fe.attack();
            fe.fly();
            fe.die();
        }
    }
    class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }

        public Enemy(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public void attack()
        {
            Console.WriteLine("Attacking");
        }
        public void die()
        {
            Console.WriteLine(name + " is dead");
        }
    }
    class BasicEnemy : Enemy
    {
        public int walkSpeed { get; set; }
        public BasicEnemy(string name, int health, int walkSpeed) : base(name, health)
        {
            this.walkSpeed = walkSpeed;
        }

        public void attack()
        {
            base.attack();
            Console.WriteLine(" on the floor");
        }
        public void walk()
        {
            Console.WriteLine(name + " is walking");
        }

    }
    class FlyingEnemy : Enemy
    {
        public int flightSpeed { get; set; }
        public FlyingEnemy(string name, int health, int flightSpeed) : base(name, health)
        {
            this.flightSpeed = flightSpeed;
        }
        public void attack()
        {
            base.attack();
            Console.WriteLine(" in the ayer");
        }
        public void fly()
        {
            Console.WriteLine(name + "is flying");
        }
    }
}
