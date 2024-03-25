using lotto.Models;
using lotto.Services;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lotto Program");

            // Initialize a LottoService instance
            var LottoService = new LottoService();

            // Get user input for the number of lines
            Console.Write("Enter the number of lines from (2-3): ");
            int numberOflines = int.Parse(s: Console.ReadLine());

            // Validate the number of lines
            if (numberOflines < 2 || numberOflines > 8)
            {
                Console.WriteLine("Invalid number of lines. Please enter a number between 2 and 8.");
                return;
            }

            // Initialize lists to store user-chosen numbers and winning numbers
            List<List<int>> userChosenNumbers = new List<List<int>>();
            List<int> winningNumbers = LottoService.GenerateRandomNumbers();

            // Generate random numbers for each line
            for (int i = 0; i < numberOflines; i++)
            {
                Console.WriteLine($"\nline {i + 1}:");

                // Get user input for choosing numbers or quick pick
                Console.WriteLine("Choose your numbers for this line (enter 0 for quick pick):");
                List<int> chosenNumbers;
                int[] userNumbers = Array.Empty<int>();

                while (userNumbers.Length == 0)
                {
                    userNumbers = UserInput.GetUserNumbers().ToArray();
                    if (userNumbers.Length == 0)
                    {
                        userNumbers = LottoService.GenerateRandomNumbers().ToArray();
                        Console.WriteLine($"Quick pick: {string.Join(", ", userNumbers)}");
                    }
                }

                chosenNumbers = new List<int>(userNumbers);

                // Validate and add chosen numbers to the line
                var line = new Lottoline();
                foreach (var number in chosenNumbers)
                {
                    try
                    {
                        line.AddNumber(number);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                // Store user-chosen numbers for each line
                userChosenNumbers.Add(chosenNumbers);

                // Check if the line is a winner
                bool isWinner = LottoService.IslineWinner(chosenNumbers, winningNumbers);
                Console.WriteLine($"line {i + 1} {(isWinner ? "is" : "is not")} a winner.");
            }

            // Calculate the total Total of the Lotto ticket
            decimal totalTotal = LottoService.CalculateTotalTotal(numberOflines);
            Console.WriteLine($"\nTotal Total of the Lotto ticket: {totalTotal} euro");

            // Print the winning numbers
            Console.WriteLine("\nWinning Numbers:");
            Console.WriteLine(string.Join(", ", winningNumbers));
        }
    }
}
