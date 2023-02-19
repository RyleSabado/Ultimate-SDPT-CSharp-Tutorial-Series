using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class _2DArray
    {

        static public void _2DArrayLesson()
        {
            //declaration: datatype[,] variablename = new datatype[rows,cols]
            //or: datatype[,] variablename = {{0,1},{1,1}}
            /*
            string[,] name = { { "ryle", "ryle123" }, { "mark", "mark123" } };
            string[,] users = new string[5, 5];
            //Read Values
            Console.WriteLine(name[0, 1]); //Prints ryle123
            //Writing Values
            name[0, 0] = "Ella";
            Console.WriteLine(name[0, 0]); //replaces ryle with Ella
            

            //Nested for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop: " + i);
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(j);
                }
            }
            */
            //Getting Length
            string[,] name = { { "ryle", "ryle123" }, { "mark", "mark123" }, {"ella", "ella123" }, {"erlinda", "erlinda123" }, {"diego", "diego123" } };
            Console.WriteLine("Rows: " + name.GetLength(0)); //get values for rows or number of inside brackets which is 5
            Console.WriteLine("Columns: " + name.GetLength(1));
            /*
            for (int row=0; row < name.GetLength(0); row++)
            {
                for(int col=0; col < name.GetLength(1); col++)
                {
                    Console.WriteLine(name[row, col]);
                }
                Console.WriteLine();
            }
            */
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
            
            

        }
    }
}
