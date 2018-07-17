using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkInt;
            Console.WriteLine("Do you want to check even/odd numbers? Y/N");
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower().Equals("y"))
            {
                do
                {
                    Console.WriteLine("Pleasse enter your number: ");
                    string number = Console.ReadLine();
                    if (int.TryParse(number, out checkInt))
                    {
                        if ((checkInt % 2) == 0)
                        {
                            Console.WriteLine("You entered number {0} and is an even number", checkInt);
                        }
                        else
                        {
                            Console.WriteLine("You entered number {0} and is an odd number", checkInt);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter integer value");
                    }
                    Console.WriteLine("Do you want to check even/odd numbers? Y/N");
                    userChoice = Console.ReadLine();

                } while (userChoice.ToLower().Equals("y"));
            }
        }
    }
}
