namespace Topic_7___Lists_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            List<string> veg = new List<string>();
            veg.Add("Carrot"); veg.Add("Beet"); veg.Add("Celery"); veg.Add("Radish"); veg.Add("Cabbage");
            bool menu = true;
            int option;
            while (menu) 
            {
                Console.WriteLine("Welcome to Geoffrey's Glorious Garden");
                Console.WriteLine();
                Console.WriteLine("Here is your garden:");
                for (int i = 0; i < veg.Count; i++)
                    Console.WriteLine(i + ". " + veg[i]);
                Console.WriteLine();
                Console.WriteLine("1 -- Pick a vegetable using its numerical index");
                Console.WriteLine("2 -- Pick a vegetable by its name");
                Console.WriteLine("3 -- Search for a vegetable");
                Console.WriteLine("4 -- Plant a vegetable");
                Console.WriteLine("5 -- Sort the garden");
                Console.WriteLine("6 -- Clear the garden...and quit the program");
                while (!Int32.TryParse(Console.ReadLine(), out option))
                    Console.WriteLine("Invalid Numeric Input.  Try again.");
                if (option == 1)
                {
                    Console.WriteLine("Here is your garden:");
                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 2) 
                {
                    Console.WriteLine("Here is your garden:");
                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 4)
                {
                    Console.WriteLine("Here is your garden:");
                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 5)
                {
                    veg.Sort();
                    Console.WriteLine("Here is your sorted garden:");
                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 6)
                {
                    Console.WriteLine("Here is your final garden:");
                    for (int i = 0; i < veg.Count; i++)
                        Console.WriteLine(i + ". " + veg[i]);
                    
                    Console.WriteLine("Press Enter to say goodbye :(");
                    Console.ReadLine();
                    menu = false;
                }
            }
        }
    }
}