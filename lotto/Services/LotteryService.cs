using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Services
{
 
        public class LottoService
        {
            // Generate random numbers for a line
            public List<int> GenerateRandomNumbers()
            {
                List<int> randomNumbers = new List<int>();
                Random random = new Random();

                // Generate 6 random numbers between 1 and 50
                while (randomNumbers.Count < 6)
                {
                    int randomNumber = random.Next(1, 51);
                    if (!randomNumbers.Contains(randomNumber))
                    {
                        randomNumbers.Add(randomNumber);
                    }
                }

                return randomNumbers;
            }

            // Check if a line is a winner
            public bool IslineWinner(List<int> lineNumbers, List<int> winningNumbers)
            {
                foreach (int number in winningNumbers)
                {
                    if (!lineNumbers.Contains(number))
                    {
                        return false;
                    }
                }

                return true;
            }

            // Calculate the total Total of a Lotto ticket
            public decimal CalculateTotalTotal(int numberOflines)
            {
                const decimal TotalPerline = 2; // 2 euro per line
                return numberOflines * TotalPerline;
            }
        }
    }
