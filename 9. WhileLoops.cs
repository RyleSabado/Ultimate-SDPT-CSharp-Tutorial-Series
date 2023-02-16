using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class WhileLoops
    {
        public static void WhileLoopsLesson()
        {
            /*
            //while loops
            string[] names = { "ryle", "mark", "ella", "erlinda", "diego" };
            int i = 0; //starting condition
            while (i < names.Length) //condtion, current length, 3
            {
                if (names[i] == "ella")
                {
                    Console.Write(i + 1);
                    Console.WriteLine(" I found " + names[i]);
                    break;
                }
                Console.Write(i + 1);
                Console.WriteLine(" I found " + names[i]);
                i++; //increases the value of i to meet the condition, without this the output will loop nonstop
            }
            //to prevent errors on condition on arrays, use arrayname.Length (12:25)

            //------------------------------------------
            
            //do while loops (15:38)
            //same as while but executes the code atleast once before checking the condition
            int j = 5;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while(j < 5);
            {
                Console.WriteLine(j);
            }
            */
            //challenge
            int lives = 3;
            while (lives > 0)
            {
                Console.Write("What is the correct answer?: ");
                string answer = Console.ReadLine();
                if (answer == "Ryle")
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    lives--;
                    Console.WriteLine("Wrong, lives left: " + lives);
                    if (lives == 0)
                    {
                        Console.WriteLine("You ran out of lives");
                    }
                }
            }
        }
    }
}
