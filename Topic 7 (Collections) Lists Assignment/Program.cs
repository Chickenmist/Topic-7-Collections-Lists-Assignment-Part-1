using System.ComponentModel.DataAnnotations;

namespace Topic_7__Collections__Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();

            int number = 0, running = 1, selection, removal;

            Console.WriteLine("Here's the list of random numbers: ");

            for (int i = 0; i < 25; i++)
            {
                number = random.Next(10, 21);
                numbers.Add(number);

                if (i == 0)
                {
                    Console.Write($"[{numbers[i]}, ");
                }
                else if (i == 24)
                {
                    Console.WriteLine($"{numbers[i]}]");
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }

            while (running == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Select an option by their number: ");
                Console.WriteLine("1 - Sort List                                        2 - Make a New List of Random Numbers");
                Console.WriteLine("3 - Remove a Value From the List                     4 - Add a Value to the List");
                Console.WriteLine("5 - Count the Occurences of a Number                 6 - Print the Largest Value");
                Console.WriteLine("7 - Print the Smallest Value                         8 - Print the Sum and the Average of the Numbers in the List");
                Console.WriteLine("9 - Determine the Most Frequently Occuring Value    10 - Quit");
                Console.Write("Selection: ");
                int.TryParse(Console.ReadLine(), out selection);
                Console.WriteLine("");

                if (selection <= 0 || selection > 10)
                {
                    Console.WriteLine("Invalid Selection");
                }
                else if (selection == 1)
                {
                    numbers.Sort();

                    Console.WriteLine("Sorted List: ");

                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"[{numbers[i]}, ");
                        }
                        else if (i == numbers.Count() - 1)
                        {
                            Console.WriteLine($"{numbers[i]}]");
                        }
                        else
                        {
                            Console.Write($"{numbers[i]}, ");
                        }
                    }
                }
                else if (selection == 2)
                {
                    numbers.Clear();

                    Console.WriteLine("New List: ");
                    for (int i = 0; i < 25; i++)
                    {
                        number = random.Next(10, 21);
                        numbers.Add(number);

                        if (i == 0)
                        {
                            Console.Write($"[{numbers[i]}, ");
                        }
                        else if (i == 24)
                        {
                            Console.WriteLine($"{numbers[i]}]");
                        }
                        else
                        {
                            Console.Write($"{numbers[i]}, ");
                        }
                    }
                }
                else if (selection == 3)
                {
                    Console.WriteLine("What value do you want to remove?");
                    int.TryParse(Console.ReadLine(), out removal);

                    numbers.Remove(removal);

                    Console.WriteLine("Updated List: ");
                    
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"[{numbers[i]}, ");
                        }
                        else if (i == numbers.Count() - 1)
                        {
                            Console.WriteLine($"{numbers[i]}]");
                        }
                        else
                        {
                            Console.Write($"{numbers[i]}, ");
                        }
                    }
                }
                else if (selection == 4)
                {
                    Console.WriteLine("What number do you want to add to the list?");
                }
                else if (selection == 5)
                {

                }
                else if (selection == 6)
                {

                }
                else if (selection == 7)
                {

                }
                else if (selection == 8)
                {

                }
                else if (selection == 9)
                {

                }
                else if (selection == 10)
                {
                    running = 0;
                }
            }

        }
    }
}