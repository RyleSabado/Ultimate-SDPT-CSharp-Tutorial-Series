using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class ForEach
    {
        public static void ForEachLesson()
        {
            //Syntax: foreach(datatype identifier in collection)
            //specialized for reading arrays
            /*
            string[] names = { "Ryle", "Mark", "Ella", "Diego", "Erlinda" };
            foreach (string variablename in names)
            {
                if (variablename.Equals("Diego"))
                {
                    Console.WriteLine("I found " + variablename);
                }
            }
            */
            //Challenge: Summation of all numnbers in an array
            int sum = 0;
            int[] numArray = { 1, 2, 3, 4, 5 };
            foreach (int num in numArray)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
