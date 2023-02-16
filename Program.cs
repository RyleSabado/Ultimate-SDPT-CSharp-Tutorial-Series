namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("A. Hello World with static field");
            Console.WriteLine("B. Hello World without static field");
            Console.WriteLine("C. User Input");
            Console.WriteLine("D. Datatype Conversion");
            Console.WriteLine("E. Arrays");
            Console.WriteLine("F. Conditional Statements");
            Console.WriteLine("G. Switch Statements");
            Console.WriteLine("H. While Loopss");
            Console.Write("Choose a letter to continue: ");
            //User input: Ep3
            //string option=Console.ReadLine();
            //Menu(option); //another option is "Menu(console.ReadLine());"
            Menu(Console.ReadLine().ToUpper());
        }

        //classes: ep14
        //methods
        static void Menu(string option)
        {
            //if-else
            if (option == "A")
            {
                Hello_World.HelloWorld();
                /*  Requires "static" in the following code in Hello World.cs:
                    public static void HelloWorld()
                    Ep14(24:11)*/
            }
            else if (option == "B")
            {
                Hello_World h = new Hello_World();
                h.HelloWorld2();
                //Ep14(9:48)
            }
            else if (option == "C")
            {
                UserInput.userInputLesson();
                //Ep14(9:48)
            }
            else if (option == "D")
            {
                DatatypeConversion.DatatypeConversionLesson();
                //Ep14(9:48)
            }
            else if (option == "E")
            {
                Arrays.ArraysLesson();
            }
            else if (option == "F")
            {
                ConditionalStatements.ConditionalStatementsLesson();
            }
            else if (option == "G")
            {
                SwitchStatements.SwitchStatementsLesson();
            }
            else if (option == "H")
            {
                WhileLoops.WhileLoopsLesson();
            }
            else
            {
                Console.WriteLine("Wrong Hole");
            }
        }
    }
}