using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto.Models
    {
        // This is to calculate the Total of a Lotto ticket
        public class TotalCalculator
        {
            // Total per line
            private const decimal TotalPerline = 2;

            // This wil calculate the total cost of ticket
            public static decimal CalculateTotalTotal(int numberOflines)
            {
                // This will calculate number of lines
                return numberOflines * TotalPerline;
            }
        }
    }

