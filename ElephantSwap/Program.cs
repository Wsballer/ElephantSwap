using System;

namespace ElephantSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("You pressed 1\nCalling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == "2")
                {
                    Console.WriteLine("You pressed 2\nCalling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == "3")
                {
                    Console.WriteLine("You pressed 3\nReferences have been swapped");
                    Elephant holder;
                    holder = lucinda;
                    lucinda = lloyd;
                    lloyd = holder;
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
