using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Models
{

     
        public class LottoTicket
        {
            // Number of lines on the ticket
            public int NumberOflines { get; private set; }

            // List of lines on the ticket
            public List<Lottoline> lines { get; private set; }

           
            public LottoTicket(int numberOflines)
            {
                // check number of lines
                if (numberOflines < 2 || numberOflines > 8)
                {
                    // Throw an exception if the number of lines is not within the allowed range
                    throw new ArgumentException("Number of lines must be between 2 and 8.");
                }

           
                NumberOflines = numberOflines;
                lines = new List<Lottoline>();
            }

            public void Addline(Lottoline line)
            {
                // Check if the maximum number of lines has been reached
                if (lines.Count >= NumberOflines)
                {
                  
                    throw new InvalidOperationException("You have reached your Max Numbers.");
                }

                // Add a line to the list
                lines.Add(line);
            }

            // it will Calculate the total cost of the ticket
            public decimal CalculateTotalTotal()
            {
                // Cost per line is 2 euro, calculate total cost
                return NumberOflines * 2;
            }
        }
    }

