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
            int option, postion, removeNum;
            string add, contain, remove;
            while (menu) 
            {
                Console.WriteLine("Welcome to Geoffrey's Glorious Garden.");
                Console.WriteLine();
                Console.WriteLine("Here is your garden:");
                for (int i = 0; i < veg.Count; i++)
                    Console.WriteLine(i + ". " + veg[i]);
                Console.WriteLine();
                Console.WriteLine("1 -- Pick a vegetable using its numerical index and remove it.");
                Console.WriteLine("2 -- Pick a vegetable by its name and remove it.");
                Console.WriteLine("3 -- Search for a vegetable.");
                Console.WriteLine("4 -- Plant a vegetable.");
                Console.WriteLine("5 -- Sort the garden.");
                Console.WriteLine("6 -- Clear the garden...and quit the program.");
                while (!Int32.TryParse(Console.ReadLine(), out option))
                    Console.WriteLine("Invalid Numeric Input.  Try again.");

                if (option == 1)
                {
                    Console.WriteLine("Search for a vegetable via its number");

                    while (!Int32.TryParse(Console.ReadLine(), out removeNum))
                        Console.WriteLine("Invalid Numeric Input.  Try again.");

                    veg.Remove(veg[removeNum]);

                    for (int i = 0; i < veg.Count; i++)
                    {
                        Console.WriteLine(i + ". " + veg[i]);
                    }

                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 2) 
                {
                    Console.WriteLine("Search for a vegetable to remove.");
                    remove = Console.ReadLine().ToUpper();
                    if (veg.Contains(remove))
                    {
                        veg.Remove(remove);
                        Console.WriteLine("Vegetable located...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Removing...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Vegetable succesfully removed.");
                        Console.WriteLine();
                        Console.WriteLine("Here is your new garden:");
                        for (int i = 0; i < veg.Count; i++)
                        {
                            Console.WriteLine(i + ". " + veg[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Locating vegetable...");
                        Thread.Sleep(1000);
                        Console.WriteLine("ERROR 404: vegetable not found");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

                else if (option == 3)
                {
                    Console.WriteLine("Search for a vegetable please.");
                    Console.WriteLine();
                    contain = Console.ReadLine().ToUpper(); 

                    if (veg.Contains(contain))
                    {
                        Console.WriteLine("Your garden contains the vegetable: " + contain.ToUpper() + ".");
                    }
                    else if (!veg.Contains(contain))
                    {
                        Console.WriteLine("It seems your garden does not contain the vegetable: " + contain + ".");
                    }

                    for (int i = 0; i < veg.Count; i++)
                    {
                        if (veg[i] == contain)
                        {
                            Console.WriteLine("Your vegetable is planted at the #" + (i + 1) + " postion in your garden");
                        }
                    }
                    
                    Console.WriteLine("Press Enter to continue");
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