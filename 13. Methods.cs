using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class Methods
    {
        //L: Methods/Functions
        public static void MethodsLesson()
        {
            /*
            SayHello();
            GreetSomeone("Ryle", 1000);
            Console.WriteLine(add(5, 10));
            Console.WriteLine(MakeName("Ryle", "sabado"));
            Console.WriteLine(add(1, 3, 4));
            */
            /*Challenge Solution 1
            int x = summationArray(5, 6, 7);
            Console.WriteLine(x);
            */
            //Challenge Solution 2
            int[] numbers = { 1, 3, 3, 4, 5 };
            Console.WriteLine(summationArray(numbers));
        }
        /*
        //Variable Scoping (16:20)
        //Global Variables: Variables Declared within a class; requires the variable name to be static
        //Local Variables: Variables that can be accessed inside a method, condition, loops
        static int numX = 20;
        static string name = "Ryle";
        static void SayHello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Someone's name is " + name + "; There is also " + numX + " birds flying");
        }

        //Methods with parameters/arguments(27:49)
        static void GreetSomeone(string name, int num)
        {
            Console.WriteLine("XXSomeone's name is " + name + "; There is also " + num + " birds flying");
        }
        
        //Return keyword(37:34)
        static int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static string MakeName(string firstname, string lastname)
        {
            return firstname + " " + lastname;
        }

        //Overloading Methods(44:08)
        static int add (int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        */
        //challenge
        static int summationArray(int a, int b, int c)
        {
            int[] numArray = new int[3];
            int sum = 0;
            numArray[0] = a;
            numArray[1] = b;
            numArray[2] = c;
            foreach (int i in numArray)
            {
                sum += i;
                
            }
            return sum;
        }

        //Another solution
        static int summationArray(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}
