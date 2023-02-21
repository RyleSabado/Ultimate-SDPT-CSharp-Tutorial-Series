using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 17: Object Methods | P
    internal class ObjectMethods
    {
        public static void ObjectMethodsLesson()
        {
            Console.WriteLine("First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Course: ");
            string course = Console.ReadLine();
            Console.WriteLine("Section: ");
            string section = Console.ReadLine();
            Console.WriteLine("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Midterm Grade: ");
            double midtermgrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Grade: ");
            double finalgrade = Convert.ToDouble(Console.ReadLine());

            StudentChallenge sc = new StudentChallenge(firstname, lastname, course, section,year, midtermgrade, finalgrade);
            sc.introduceSelf();
            sc.evaluateGrade();
            /*
            CharacterEp17 c = new CharacterEp17("Ryke", "Hello", 100, 100, 100);
            Console.WriteLine(c.introduce());
            c.say();
            */
        }
        
    }
    /*
    public class CharacterEp17
    {
        public string name, dialogue;
        public int hp, mp, lvl;

        public CharacterEp17(string name, string dialogue, int hp, int mp, int lvl)
        {
            this.name = name;
            this.dialogue = dialogue;
            this.hp = hp;
            this.mp = mp;
            this.lvl = lvl;
        }

        public string introduce()
        {
            return "I am " + name;
        }

        public void say()
        {
            Console.WriteLine(name + ": " + dialogue);
        }
    }
    */
    //Challenge:
    class StudentChallenge
    {
        public string firstName, lastName, section, course;
        public int year;
        public double midtermGrade, finalGrade;

        public StudentChallenge(string firstName, string lastName, string course, string section, int year, double midtermGrade, double finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.section = section;
            this.year = year;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        //
        public void introduceSelf()
        {
            Console.WriteLine("Name     :"+ firstName+ " " + lastName);
            Console.WriteLine("Course   :" + course);
            Console.WriteLine("Year:    :" + year);
            Console.WriteLine("Section: " + section);
        }
        public void evaluateGrade()
        {
            finalGrade = (midtermGrade + finalGrade) / 2;
            Console.WriteLine("Final Grade  :" + finalGrade);
            if (finalGrade >= 90) Console.WriteLine("With Honors");
            else if (finalGrade >= 75) Console.WriteLine("Passed");
            else Console.WriteLine("Failed");
        }
    }
}
