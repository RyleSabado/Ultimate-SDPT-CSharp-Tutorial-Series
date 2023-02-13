using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class DatatypeConversion
    {
        public static void DatatypeConversionLesson() 
        {
            //Implicit Casting: char>int>long>float>double || Cant convert backwards
            int myInt = 10;
            double myDouble = myInt;

            Console.WriteLine("Int to double: " + myDouble);

            //Explicit Casting: double>float>long>int>char
            double myDouble2 = 25.32;
            int myInt2 = (int)myDouble2;
            Console.WriteLine("Double to int: " + myInt2);

            int asciiCode = 66;
            char myChar= (char)asciiCode;
            Console.WriteLine("Int to char: " + myChar);

        }
    }
}
