using NumberGuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int low = 1;
            int high = 100;
            int maxChances = 10;    
            int chance = 0;         
            bool win = false;      
            bool check = true;


            //This while loop run until you exit the game 
            while(check)
            {

                Console.WriteLine("Welcome to the Number Guessing Game");

                Random random = new Random();
                int number = random.Next(low, high); // number contain any value from low to high

                //This loop will run until you out of chances
                while (maxChances != chance)
                {
                    Console.WriteLine($"Guess the number within {low} to {high}: ");
                    int guess = int.Parse(Console.ReadLine());

                    string output = NumberGuesser.NumberGuessing(number, guess);
                    chance++;

                    if (output == "correct")
                    {
                        Console.WriteLine($"Congratulations! You guessed the correct number in {chance} chances.");
                        win = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{output}. Try again\n");
                    }
                }

                if (!win)
                {
                    Console.WriteLine($"Sorry, you ran out of chances. The correct number was {number}.");
                }
                Console.WriteLine("Press 1 to Play Again \n Press 0 to Exit ");
                int action = int.Parse(Console.ReadLine());
                if(action == 0)
                {
                    check = false;
                }

            }
            

        }
    }
}
