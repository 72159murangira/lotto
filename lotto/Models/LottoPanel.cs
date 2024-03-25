using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Models
{
    // Represents a single line on a Lotto ticket
    public class Lottoline
    {
        // Maximum number of numbers that can be chosen for a line
        private const int MaxNumbersPerline = 6;

        // Chosen numbers for the line
        public List<int> ChosenNumbers { get; private set; }

        // Constructor
        public Lottoline()
        {
            ChosenNumbers = new List<int>();
        }

        // Add a chosen number to the line
        public void AddNumber(int number)
        {
            // Validate that the number is within the allowed range (1-50)
            if (number < 1 || number > 50)
            {
                throw new ArgumentException("Numbers You pick must be between 1 and 50.");
            }

            // Validate that the line does not exceed the maximum number of chosen numbers
            if (ChosenNumbers.Count >= MaxNumbersPerline)
            {
                throw new InvalidOperationException($"Cannot add more than {MaxNumbersPerline} numbers to the line.");
            }

            // Validate that the number is not already chosen
            if (ChosenNumbers.Contains(number))
            {
                throw new InvalidOperationException("Number already entered.");
            }

            // Add the number to the list of chosen numbers
            ChosenNumbers.Add(number);
        }

        // Generate random numbers for the line
        public void GenerateRandomNumbers()
        {
            // Initialize a random number generator
            Random random = new Random();

            // Clear any existing chosen numbers
            ChosenNumbers.Clear();

            // Generate random numbers until the line has the maximum number of chosen numbers
            while (ChosenNumbers.Count < MaxNumbersPerline)
            {
                // Generate a random number between 1 and 50
                int randomNumber = random.Next(1, 51);

                // Add the number to the line if it's not already chosen
                if (!ChosenNumbers.Contains(randomNumber))
                {
                    ChosenNumbers.Add(randomNumber);
                }
            }
        }

        // Check if the line contains winning numbers
        public bool IsWinner(List<int> winningNumbers)
        {
            
            foreach (int number in winningNumbers)
            {
                if (!ChosenNumbers.Contains(number))
                {
                    return false;
                }
            }

            // All winning numbers are contained in the chosen numbers for the line
            return true;
        }
    }
}
