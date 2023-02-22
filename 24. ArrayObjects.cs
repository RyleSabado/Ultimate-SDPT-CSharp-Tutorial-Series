using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 24: Array of Objects | W
    /*
    internal class ArrayObjects
    {
        public static void ArrayObjectsLesson()
        {
            //ClassName[] identifier = new Classname[size]
            Employee[] employees = new Employee[2];
            //Storing objects inside an array(6:37)
            //identifier[index] = new ClassName(constructor)
            employees[0] = new Employee("Ryle", "Sabado", "Engineer", 25000.00);
            employees[1] = new Employee("Ella", "Sabado", "PT", 15000.00);
            foreach (Employee x in employees) 
            {
                x.IntroduceSelf();
            }
            
        }
    }
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string position { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string lastName, string position, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.salary = salary;
        }
        public void IntroduceSelf()
        {
            Console.WriteLine("Hello my name is: " + firstName);
        }
    }
    */
    /*
    //Array of Objects and Polymorphism(14:40)
    internal class ArrayObjects
    {
        public static void ArrayObjectsLesson()
        {
            //BaseClass[] identifier = new BaseClass[size]
            //identifier[index] = new DerivedClass(constructor)
            AnimalAO[] animals = new AnimalAO[2];
            animals[0] = new PigAO();
            animals[1] = new DogAO();
            for (int i=0; i<animals.Length; i++)
            {
                animals[i].MakeSound();
            }

        }
    }
    abstract class AnimalAO
    {
        public abstract void MakeSound();
    }
    class DogAO : AnimalAO
    {
        public override void MakeSound()
        {
            Console.WriteLine("arf");
        }
        public void Dig()
        {

        }
    }
    class PigAO : AnimalAO
    {
        public override void MakeSound()
        {
            Console.WriteLine("oink");
        }
    }
    */
    //Challenge
    internal class ArrayObjects
    {
        public static void ArrayObjectsLesson()
        {
            string firstname, lastname, course, section;
            int year;
            Console.Write("Input Number of Students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            StudentEP25[] student = new StudentEP25[numStudents];
            for (int i=0; i<student.Length; i++)
            {
                Console.Write("First Name: ");
                firstname = Console.ReadLine();
                Console.Write("Last Name: ");
                lastname = Console.ReadLine();
                Console.Write("Year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Course: ");
                course = Console.ReadLine();
                Console.Write("Section: ");
                section = Console.ReadLine();
                student[i] = new StudentEP25(firstname, lastname, year, course, section);
            }
            foreach (StudentEP25 studentEP25 in student)
            {
                studentEP25.introduceSelf();
            }

        }
    }
    class StudentEP25
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int year { get; set; }
        public string course { get; set; }
        public string section { get; set; }

        public StudentEP25(string firstName, string lastName, int year, string course, string section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;

            
        }
        public void introduceSelf()
        {
            Console.WriteLine("Student Info");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Section: " + year);
        }
        
    }
}
