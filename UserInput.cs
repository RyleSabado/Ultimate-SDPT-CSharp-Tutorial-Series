using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class UserInput
    {
        public static void userInputLesson()
        {
            string input1;
            Console.Write("Enter a word: ");
            input1 = Console.ReadLine();

            //Console.ReadLine() is a string, so other data types must be converted!
            Console.Write("Enter a character: ");
            char input2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a decimal: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            //This is what happens when didn't convert
            Console.Write("Enter a letter[Console.Read()]: ");
            int input5 = Console.Read();

            //with concatenation
            Console.WriteLine();
            Console.WriteLine("Word Entered: " + input1);
            Console.WriteLine("Character Entered(Convert): " + input2);
            Console.WriteLine("Number Entered: " + input3);
            Console.WriteLine("Decimal Entered: " + input4);
            Console.WriteLine("Console.Read() Letter: " + input5);
            //Combination
            Console.WriteLine();
            Console.WriteLine("String+Char  :" + input1 + input2);
            Console.WriteLine("String+Int   :" + input1 + input3);
            Console.WriteLine("Int+Double   :" + (input3 + input4));


        }
    }
}
