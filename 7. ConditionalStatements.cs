using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class ConditionalStatements
    {
        public static void ConditionalStatementsLesson()
        {
            /*
            //Relational Operators: ==, !=, <, <=, >, >=
            //Logical Operators: &&, ||, !

            //Equals Method (46:00): 
            Console.Write("Enter Usermame: ");
            string username = Console.ReadLine();

            if (username == "Ryle") //When string is case sensitive
            {
                Console.WriteLine("Login Success ==");
            }
            //When string is case sensitive
            else if (username.Equals("Sabado",StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Login Success .Equals");
            }
            else 
            { 
                Console.WriteLine("Access Denied"); 
            }
            */
            //Challenge
            Console.Write("Input Grade 1:");
            double grade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Grade 2:");
            double grade2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Grade 3:");
            double grade3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Grade 4:");
            double grade4 = Convert.ToInt32(Console.ReadLine());

            double avegrade = (grade1 + grade2 + grade3 + grade4) / 4;
            Console.WriteLine("Average: " + avegrade);

            //When using code with 1 line of code, just put it beside the statement (1:06:25)
            if (avegrade > 100) Console.WriteLine("Invalid Grade");
            else if (avegrade >= 98) Console.WriteLine("With Highest Honors");
            else if (avegrade >= 95) Console.WriteLine("With High Honors");
            else if (avegrade >= 90) Console.WriteLine("With Honors");
            else if (avegrade >= 75) Console.WriteLine("Passed");
            else if (avegrade < 75) Console.WriteLine("Failed");
        }
    }
}
