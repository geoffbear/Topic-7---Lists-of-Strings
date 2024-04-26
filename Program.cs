using System.Diagnostics;

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
            veg.Add("CARROT"); veg.Add("BEET"); veg.Add("CELERY"); veg.Add("RADISH"); veg.Add("CABBAGE");
            bool menu = true;
            int option;
            string add;
            while (menu) 
            {
                Console.WriteLine("Welcome to Geoffrey's Glorious Garden.");
                Console.WriteLine();
                Console.WriteLine("Here is your garden:");
                for (int i = 0; i < veg.Count; i++)
                    Console.WriteLine(i + ". " + veg[i]);
                Console.WriteLine();
                Console.WriteLine("1 -- Pick a vegetable using its numerical index.");
                Console.WriteLine("2 -- Pick a vegetable by its name.");
                Console.WriteLine("3 -- Search for a vegetable.");
                Console.WriteLine("4 -- Plant a vegetable.");
                Console.WriteLine("5 -- Sort the garden.");
                Console.WriteLine("6 -- Clear the garden...and quit the program.");
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
                    Console.WriteLine("Press Enter to continue.");
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
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }

                else if (option == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }

                else if (option == 4)
                {
                    Console.WriteLine("Here is your garden:");
                    for (int i = 0; i < veg.Count; i++)
                        Console.WriteLine(i + ". " + veg[i]);

                    Console.WriteLine();
                    Console.WriteLine("Type a vegetable you would like to plant.");
                    add = Console.ReadLine();
                    add = add.ToUpper();
                    veg.Add(add);
                    while (veg.Contains(add.ToUpper()))
                    {
                        Console.WriteLine("Looks like this vegetable is already planted, please try again.");
                        add = Console.ReadLine();
                        add = add.ToUpper();
                        veg.Add(add);
                    }
                    Console.WriteLine("Wow, I love " + add + "! Here it is planted to your garden.");
                    for (int i = 0; i < veg.Count; i++)
                        Console.WriteLine(i + ". " + veg[i]);

                    Console.ReadLine();
                }

                else if (option == 5)
                {
                    Console.WriteLine("Sorting..");
                    Thread.Sleep(2000);
                    veg.Sort();
                    Console.WriteLine("Here is your sorted garden:");
                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }

                else if (option == 6)
                {
                    Console.WriteLine("Here is your final garden:");
                    for (int i = 0; i < veg.Count; i++)
                        Console.WriteLine(i + ". " + veg[i]);
                    
                    Console.WriteLine("Press Enter to say goodbye :(");
                    veg.Clear();
                    Console.WriteLine("Here it is cleared:");
                    for (int i = 0; i < veg.Count; i++)
                        Console.WriteLine(i + ". " + veg[i]);
                    Console.WriteLine("Press Enter to quit.");
                    Console.ReadLine();
                    menu = false;
                }
            }
        }
    }
}