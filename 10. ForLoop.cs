using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class ForLoop //I
    {
        public static void ForLoopLesson()
        {
            //syntax: initialization(int i=0); condition(i<5); operation(i++)
            //iterating arrays
            /*
            string[] names = { "ryle", "mark", "ella", "diego", "erlinda" };
            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */
            //challenge
            string[] username = { "ryle", "mark", "ella" };
            string[] password = { "ryle123", "mark123", "ella123" };
            Console.Write("Enter Username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter Password: ");
            string passwordInput = Console.ReadLine();
            bool isFound = false;
            for (int i = 0; i < username.Length; i++)
            {
                if (usernameInput.Equals(username[i],StringComparison.CurrentCultureIgnoreCase) && passwordInput == password[i])
                {
                    Console.WriteLine("Login success");
                    isFound= true;
                    break;

                }
            }
            if (!isFound)
            {
                Console.WriteLine("account not found");
            }

        }
    }
}
