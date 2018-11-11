using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            Random rnd = new Random();
            int Number = rnd.Next(0, 100);
            Console.WriteLine("Insert First Number\n");
            int FirstNumber = 0;
            FirstNumber = insert(FirstNumber);

            if (Number == FirstNumber)
            {
                Console.WriteLine("You are lucky");
            }
            else
            {
                Console.WriteLine("Answer " + warmercolder(FirstNumber, Number));
                Console.ReadLine();
            }
        }

        static int warmercolder(int First, int Number)
        {
            int Next = 0;
            Console.WriteLine("Insert Next Number ");
            Next = insert(Next);

            while (Number != Next)
            {
                Console.WriteLine(Math.Abs(Number - Next) < Math.Abs(Number - First) ? "\nWarmer" : "\nColder");
                Console.WriteLine("\nNew Number ");
                First = Next;
                Next = insert(Next);

            }
            return Next;
        }

        static int insert(int insert)
        {
            try
            {
                insert = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Недопустимое число");
                insert = Program.insert(insert);
            }

            return insert;
        }

    }
}
