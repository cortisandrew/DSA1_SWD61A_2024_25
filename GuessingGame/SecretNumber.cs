using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class SecretNumber
    {
        private int maxNumber;
        private int secretNumber;
        private int guesses = 0;

        // One RNG shared between all instances of type secret number
        private static Random r = new Random();

        /// <summary>
        /// We are going to allow the program to select the secret number (to enable testing!)
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <param name="chosenSecretNumber"></param>
        internal SecretNumber(int maxNumber = 100, int? chosenSecretNumber = null) {
            this.maxNumber = maxNumber;
            // keep a secret number between 1 and the maxNumber (both inclusive)

            if (chosenSecretNumber == null)
            {
                this.secretNumber = r.Next(1, maxNumber + 1);
            }
            else
            {
                if (chosenSecretNumber.Value < 1 || chosenSecretNumber.Value > maxNumber) {
                    throw new ArgumentOutOfRangeException(nameof(chosenSecretNumber), "The secret number is not allowed!");
                }

                this.secretNumber = chosenSecretNumber.Value;
            }

#if DEBUG
            Console.WriteLine($"The secret number is {this.secretNumber}");
#endif
        }

        internal int MaxNumber
        {
            get { return this.maxNumber; }
        }

        internal int TotalGuesses { get { return this.guesses; } }

        /// <summary>
        /// A user makes a guess, by  passing the number guess
        /// Each guess takes 1 time to make
        /// </summary>
        /// <param name="guess"></param>
        /// <returns>Returns 0 if you have guessed the secret number
        /// Returns -1 if your guess is too small
        /// Returns 1 if your guess is too large</returns>
        internal int Guess(int guess)
        {
            guesses++; // 1 time to make your guess

            return guess.CompareTo(secretNumber);
        }
    }
}
