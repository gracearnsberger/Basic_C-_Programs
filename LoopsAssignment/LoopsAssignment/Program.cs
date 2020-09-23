using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my number between 1 & 10.");
            int numberGuess = Convert.ToInt32(Console.ReadLine());
            bool guessedNumber = false;

            while (guessedNumber == false)
            {

                switch (numberGuess)
                {
                    case 2:
                        Console.WriteLine("You guessed 2. You're not right.");
                        Console.WriteLine("Guess a number?");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. You're not right.");
                        Console.WriteLine("Guess a number?");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try higher.");
                        Console.WriteLine("Guess a number?");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7! You're correct!");
                        guessedNumber = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Think middle of the numbers.");
                        Console.WriteLine("Guess a number?");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.Read();
            }
        }
    }
}


//namespace LoopsProgram
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Guess what number of the month is my birthday!?");
//                int number = Convert.ToInt32(Console.ReadLine());
//                bool isGuessed = number == 22;

//                do
//                {
//                    switch (number)
//                    {
//                        case 20:
//                            Console.WriteLine("You guessed the 20th. You're close but not right.");
//                            Console.WriteLine("Guess a number?");
//                            number = Convert.ToInt32(Console.ReadLine());
//                            break;
//                        case 10:
//                            Console.WriteLine("You guessed the 10th. Try higher.");
//                            Console.WriteLine("Guess a number?");
//                            number = Convert.ToInt32(Console.ReadLine());
//                            break;
//                        case 30:
//                            Console.WriteLine("You guessed the 30th. Try lower.");
//                            Console.WriteLine("Guess a number?");
//                            number = Convert.ToInt32(Console.ReadLine());
//                            break;
//                        case 22:
//                            Console.WriteLine("You guessed the 22nd! You're correct!");
//                            isGuessed = true;
//                            break;
//                        default:
//                            Console.WriteLine("You are wrong. Think middle of the month.");
//                            Console.WriteLine("Guess a number?");
//                            number = Convert.ToInt32(Console.ReadLine());
//                            break;
//                    }
//                }

//                while (!isGuessed);

//                Console.Read();
//            }
//        }
//    }

    

