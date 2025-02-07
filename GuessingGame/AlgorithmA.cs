using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class AlgorithmA
    {
        private SecretNumber secretNumber;
        internal AlgorithmA(SecretNumber secretNumber)
        {
            this.secretNumber = secretNumber;
        }

        /// <summary>
        /// Guess all the numbers one after the other, starting from 1 up to the maximum number!
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal (int, int) Guess() {

            int maxNumber = secretNumber.MaxNumber;
            
            // Guess all the numbers one after the other, starting from 1 up to the maximum number!
            for (int i = 1; i <= maxNumber; i++)
            {
#if DEBUG
                Console.WriteLine($"Algorithm A is guessing: {i}");
#endif

                if (secretNumber.Guess(i) == 0)
                {
                    // you have guessed!
                    return (i, secretNumber.TotalGuesses);
                }
                // you have not guessed: keep guessing!
            }

            // the secret number is NOT between 1 and MaxNumber!
            // there is an error somewhere in the code!
            throw new ApplicationException("The secret number is NOT between 1 and MaxNumber! There is an error somewhere in the code!");
        }
    }
}
