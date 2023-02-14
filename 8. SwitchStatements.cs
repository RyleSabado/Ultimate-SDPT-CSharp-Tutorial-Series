using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class SwitchStatements
    {
        public static void SwitchStatementsLesson()
        {
            /*
            //Switch only works with string, char, int, enums
            //Doesn't work with float, double, booleans
            Console.WriteLine("Enter Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 0://use appropriate symbols for each data type strings "", char ''
                    Console.WriteLine("0");
                    break; // the code is with errors if there is no break statement (16:55)
                case 1:
                    Console.WriteLine("1");
                    break;
                case 10:
                    Console.WriteLine("10");
                    break;
                default: //works  as "else", and used at the end of cases
                    Console.WriteLine("failed");
                    break;
            }
            */

            //challenge
            string monthWord = "";
            Console.Write("Month: ");
            int monthInput = Convert.ToInt32(Console.ReadLine());
            if (monthInput < 1 || monthInput > 12) Console.WriteLine("Invalid input");

            Console.Write("Day: ");
            int dayInput = Convert.ToInt32(Console.ReadLine());
            if (dayInput < 1 || dayInput > 31)
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("Year: ");
            int yearInput = Convert.ToInt32(Console.ReadLine());

            switch (monthInput)
            {
                case 1:
                    monthWord = "January";
                    break;
                case 2:
                    monthWord = "Febuary";
                    break;
                case 3:
                    monthWord = "March";
                    break;
                case 4:
                    monthWord = "April";
                    break;
                case 5:
                    monthWord = "May";
                    break;
                case 6:
                    monthWord = "June";
                    break;
                case 7:
                    monthWord = "July";
                    break;
                case 8:
                    monthWord = "January";
                    break;
                case 9:
                    monthWord = "January";
                    break;
                case 10:
                    monthWord = "January";
                    break;
                case 11:
                    monthWord = "November";
                    break;
                case 12:
                    monthWord = "December";
                    break;
                default:
                    break;
            }
            Console.WriteLine(monthWord + " " + dayInput + ", " + yearInput);
        }
    }
}
