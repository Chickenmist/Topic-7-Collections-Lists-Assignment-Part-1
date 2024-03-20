using System.ComponentModel.DataAnnotations;

namespace Topic_7__Collections__Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();

            int number = 0, running = 1, selection = 0, removal = 0, addNumber = 0, findNumber = 0, occurences = 0;

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
                else if (selection == 1) //Sort List
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
                else if (selection == 2) //Make a New List
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
                else if (selection == 3) //Remove a Value From the List
                {
                    while (removal <= 0)
                    {
                        Console.WriteLine("What value do you want to remove?");
                        int.TryParse(Console.ReadLine(), out removal);

                        if (removal <= 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid");
                            Console.WriteLine("");
                        }
                    }

                    while (numbers.Contains(removal))
                    {
                        numbers.Remove(removal);
                    }

                    Console.WriteLine("");
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
                else if (selection == 4) //Add a Value to the List
                {
                    while (addNumber <= 0)
                    { 
                        Console.WriteLine("What positive non-zero number do you want to add to the list?");
                        int.TryParse(Console.ReadLine(), out addNumber);

                        if (addNumber <= 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid");
                        }
                    }

                    numbers.Add(addNumber);

                    Console.WriteLine("");
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
                else if (selection == 5) //Count the Occurences of a Number
                {
                    Console.WriteLine("What number do you want to find the occurences of?");
                    int.TryParse(Console.ReadLine(), out findNumber);

                    occurences = numbers.Count(i => i == findNumber);

                    //foreach (int i in numbers)  This does the same thing as above, I'm just leaving it here as future reference for myself
                    //    if (i == findNumber)
                    //    {
                    //        occurences++;
                    //    }

                    Console.WriteLine("");
                    Console.WriteLine($"The number {findNumber} occurs {occurences} in the list.");
                    Console.WriteLine("");

                    Console.WriteLine("List: ");

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
                else if (selection == 6) //Print the Largest Value
                {
                    Console.WriteLine($"The largest value in the list is {numbers.Max()}.");
                    Console.WriteLine("");

                    Console.WriteLine("List: ");

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
                else if (selection == 7) //Print the Smallest Value
                {
                    Console.WriteLine($"The smallest value in the list is {numbers.Min()}.");
                    Console.WriteLine("");

                    Console.WriteLine("List: ");

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
                else if (selection == 8) //Print the Sum and the Average of the Numbers in the List
                {
                    Console.WriteLine($"The sum of the numbers in the list is {numbers.Sum()}. The average of the numbers in the list is {numbers.Average()}.");
                    Console.WriteLine("");

                    Console.WriteLine("List: ");

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
                else if (selection == 9) //Determine the Most Frequently Occuring Value
                {
                    int counterOne, counterTwo;

                    List<int> duplicateList = new List<int>();

                    duplicateList = numbers;
                    duplicateList.Sort();


                    for (int i = 0; i < duplicateList.Count(); i++)
                    {
                        
                    }

                    Console.WriteLine($"The most frequently occuring number in the list is ");
                }
                else if (selection == 10) //Quit
                {
                    running = 0;
                }
            }

        }
    }
}