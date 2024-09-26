using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Models
{
    internal class NumberGuesser
    {
        public static string NumberGuessing(int number, int guess)
        {
            if (guess == number)
            {
                return "correct";
            }
            else if (guess < number)
            {
                return "Too low";
            }
            else
            {
                return "Too high";
            }
        }
    }
}
