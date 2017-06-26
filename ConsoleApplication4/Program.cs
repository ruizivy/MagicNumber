using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int MagicNumber = r.Next(1, 101);
            int counter = 0;

            Console.WriteLine("I have a number from 1 to 100 can you guess it ? : ");
            Console.Write("Enter your guess : ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                counter++;
                if (MagicNumber == guess)
                {
                    Console.WriteLine("Correct!!");
                    Console.WriteLine("Game Over!!");
                    break;
                }
                else if (MagicNumber > guess)
                {
                    Console.WriteLine("Wrong.. the number is higher!!");
                    Console.Write("Enter your guess : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (MagicNumber < guess)
                {
                    Console.WriteLine("Wrong.. the number is lower !!");
                    Console.Write("Enter your guess : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if(counter == 5)
                {
                    Console.WriteLine("Wrong.. the correct answer is " +  MagicNumber);
                    Console.WriteLine("Game Over !!");
                    break;

                }
            }

      

        }
    }
}
