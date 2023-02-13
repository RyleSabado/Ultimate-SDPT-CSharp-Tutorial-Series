using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class Arrays
    {
        public static void ArraysLesson()
        {
            /*
            string[] names = { "Ryle", "Gideon", "Sabado" }; //with values, elements starts with 0
            string[] names1 = new string[5]; //without values, both must be the same data type

            //accessing arrays
            Console.WriteLine(names[0]); //prints "Ryle"

            //arrays with text input
            Console.WriteLine();
            string[] arrayStrinput = new string[5];
            Console.Write("String Input: ");
            arrayStrinput[0] = Console.ReadLine();

            Console.WriteLine();
            double[] arrayDoubinput = new double[5];
            Console.Write("Double Input: ");
            arrayDoubinput[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(arrayDoubinput[0]);
            */

            //Challenge
            
            string[] email = { "Ryle@outlook.ph", "Mark@outlook.ph", "Ella@outlook.ph", "Diego@outlook.ph", "Erlinda@outlook.ph" };
            string[] usernames = { "Ryle", "Mark", "Ella", "Diego", "Erlinda" };
            string[] password = { "Ryle123", "Mark123", "Ella123", "Diego123", "Erlinda123" };

            Console.Write("Enter Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Index: " + index);
            Console.WriteLine("email: " + email[index]);
            Console.WriteLine("username: " + usernames[index]);
            Console.WriteLine("password: " + password[index]);
        }
    }
}
