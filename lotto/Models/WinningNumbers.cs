using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Models
{
        // Represents the winning numbers for the Lotto
        public class WinningNumbers
        {
            // Method to generate random winning numbers
            public static List<int> GenerateWinningNumbers()
            {
                List<int> winningNumbers = new List<int>();

                // Initialize a random number generator
                Random random = new Random();

                // Generate 6 random winning numbers
                while (winningNumbers.Count < 6)
                {
                    // Generate a random number between 1 and 50
                    int randomNumber = random.Next(1, 51);

                    // Add the number to the list of winning numbers if it's not already chosen
                    if (!winningNumbers.Contains(randomNumber))
                    {
                        winningNumbers.Add(randomNumber);
                    }
                }

                return winningNumbers;
            }

            // Method to check if a line contains winning numbers
            public static bool IslineWinner(List<int> lineNumbers, List<int> winningNumbers)
            {
                // Check if all winning numbers are contained in the line's numbers
                foreach (int number in winningNumbers)
                {
                    if (!lineNumbers.Contains(number))
                    {
                        return false;
                    }
                }

                // All winning numbers are contained in the line's numbers
                return true;
            }
        }
    }

