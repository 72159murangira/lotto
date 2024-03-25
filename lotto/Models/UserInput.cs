using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Models
{
        // Represents user input for choosing numbers for a line
        public class UserInput
        {
            // Method to get user input for choosing numbers for a line
            public static List<int> GetUserNumbers()
            {
                List<int> userNumbers = new List<int>();

                // Prompt the user to enter their numbers
                Console.WriteLine("Enter your 6 numbers for the line (enter '0' to finish):");

                int number;
                do
                {
                    // Read user input
                    Console.Write("Number: ");
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        // Validate that the number is within the allowed range (1-50)
                        if (number >= 1 && number <= 50)
                        {
                            // Add the number to the list of user numbers
                            userNumbers.Add(number);
                        }
                        else if (number != 0)
                        {
                            // Notify the user if the number is not within the allowed range
                            Console.WriteLine("Pick Numbers between 1 and 50.");
                        }
                    }
                    else
                    {
                        // Notify the user if the input is not a valid number
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                } while (number != 0);

                return userNumbers;
            }
        }
    }
