using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 15 | M | Classes
    //object: created when instantiating a class; ex, person, furniture, food
    //attributes: global variables declared inside a class

    internal class Classes
    {
        
        public static void ClassesLesson()
        {
            //Instantiation(8:40)
            //Classname identifier = new Classname
            //Accessing Attributes
            //identifier.attribute = value;
            //Reading Attributes
            //Console.WriteLine(identifier.attribute);
            Person p1 = new Person();
            p1.firstName = "Ryle";
            p1.lastName = "Sabado";
            Console.WriteLine(p1.firstName);
            Console.WriteLine(p1.lastName);

            Person p2 = new Person();
            p2.firstName = "Mark";
            p2.lastName = "Sabado";
            Console.WriteLine(p2.firstName);
            Console.WriteLine(p2.lastName);

            

        }
    }

    class Person
    {
        //Attributes
        public string firstName;
        public string lastName;
        public char sex;
        public int age;
    }
}
