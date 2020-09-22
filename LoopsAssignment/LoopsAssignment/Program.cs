using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Guess what number of the month is my birthday!?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 22;

                do
                {
                    switch (number)
                    {
                        case 20:
                            Console.WriteLine("You guessed the 20th. You're close but not right.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 10:
                            Console.WriteLine("You guessed the 10th. Try higher.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 30:
                            Console.WriteLine("You guessed the 30th. Try lower.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 22:
                            Console.WriteLine("You guessed the 22nd! You're correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong. Think middle of the month.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }

                while (!isGuessed);

                Console.Read();
            }
        }
    }
}
    }
}
