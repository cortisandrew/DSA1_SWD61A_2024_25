using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class AlgorithmB
    {
        private SecretNumber secretNumber;
        internal AlgorithmB(SecretNumber secretNumber)
        {
            this.secretNumber = secretNumber;
        }

        /// <summary>
        /// Guess all the numbers one after the other, starting from 1 up to the maximum number!
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal (int, int) Guess()
        {
            int minNumber = 1;
            int maxNumber = secretNumber.MaxNumber;

            int numberToGuess = maxNumber / 2;

            while (true)
            {
                int comparisonResult = secretNumber.Guess(numberToGuess);

                if (comparisonResult == 0)
                    return (numberToGuess, secretNumber.TotalGuesses);

                // otherwise, we have not guessed!
                // try again
                if (comparisonResult < 0)
                {
                    minNumber = numberToGuess + 1;
                }
                else if (comparisonResult > 0)
                {
                    maxNumber = numberToGuess - 1;   
                }

                numberToGuess = (minNumber + maxNumber) / 2;
            }
            
        }
    }
}