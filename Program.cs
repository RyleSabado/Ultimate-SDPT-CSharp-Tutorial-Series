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
            Console.WriteLine("F. Conditional Statements"); //Also contains lesson about ignoring case
            Console.WriteLine("G. Switch Statements");
            Console.WriteLine("H. While Loops");
            Console.WriteLine("I. For Loops");
            //11 Also contains summation of numbers in array
            Console.WriteLine("J. For Each Loops"); 
            Console.WriteLine("K. 2D Arrays + Nested Loops");
            Console.WriteLine("L. Methods");
            Console.WriteLine("Q. Encapsulation");
            Console.WriteLine("R. Overloading Methods");
            Console.WriteLine("S. Inheritance");
            Console.WriteLine("T. Inheritance");
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
            else if (option == "I")
            {
                ForLoop.ForLoopLesson();
            }
            else if (option == "J")
            {
                ForEach.ForEachLesson();
            }
            else if (option == "K")
            {
                _2DArray._2DArrayLesson();
            }
            else if (option == "L")
            {
                Methods.MethodsLesson();
            }
            else if (option == "M")
            {
                Classes.ClassesLesson();
            }
            else if (option == "N")
            {
                Constructors.ConstructorsLesson();
            }
            else if (option == "O")
            {
                Constructors.ConstructorsLesson();
            }
            else if (option == "P")
            {
                ObjectMethods.ObjectMethodsLesson();
            }
            else if (option == "Q") Encapsulation.EncapsulationLesson();
            else if (option == "R") OverloadingContructors.OverloadingContructorsLesson();
            else if (option == "S") Inheritance.InheritanceLesson();
            else if (option == "T") Polymorphism.PolymorphismLesson();
            else if (option == "U") Abstraction.AbstractionLesson();
            else if (option == "V") Polymorphism.PolymorphismLesson();
            else
            {
                Console.WriteLine("Wrong Hole");
            }
        }
    }
}