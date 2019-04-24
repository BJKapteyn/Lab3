using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string uNumber = "";
                string name;
                int number = 1;

                bool isInt1To100(string num)
                {
                    if (Int32.TryParse(num, out int x))
                    {
                        number = Convert.ToInt32(num);
                        if (number >= 0 && number <= 100)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                Console.WriteLine("Welcome to the give me a number and I tell you if it's odd or even and other stuff happens...thing" +
                    "\nWhat's  your name sweetheart?");
                name = Console.ReadLine();
                Console.Write($"{name}? That's a peach of a name if I do say so myself, which I do. ");

                //promt for entering number with different repsonses in case of multiple incorrect inputs.
                for (int i = 0; i < 8; i++)
                {
                    if (i == 7)
                    {
                        Console.WriteLine("Now you done made me angry and I done told you not to! Like General Lee's modern appeal, I'm gone!");
                        Console.ReadKey();
                        return;
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("I don't take kindly to having to repeat myself. Now don't make me angry now. Let's see a number 1 - 100 dag nabbit!");
                        uNumber = Console.ReadLine();
                        if (isInt1To100(uNumber))
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("Enter yourself a number between 1 and 100");
                        uNumber = Console.ReadLine();
                        if (isInt1To100(uNumber))
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a whole number 1 to 100 ya hear?");
                        uNumber = Console.ReadLine();
                        if (isInt1To100(uNumber))
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                Console.Write($"Very good {name}, ");
                if (number % 2 == 0)
                {
                    if (number < 25)
                    {
                        Console.WriteLine($"Looks like {uNumber} is even and less than 25.");
                    }
                    else
                    {
                        Console.WriteLine($"Looks like {uNumber} is Even.");
                    }
                }
                else
                {
                    Console.WriteLine($"Looks like {uNumber} is odd.");
                }

                Console.WriteLine("Isn't that as nice as glass of sugar with some tea in it? Press R to restart or any key to quit");
                string uRestart = Console.ReadLine().ToUpper();
                if(uRestart == "R")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Well, {name} it was a pleasure meeting you, taker' easy.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
