using System;
using System.Collections.Generic;
using lotto.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using System.Linq;

namespace Lotto.Tests
{

        public class LottolineTests
        {
            [Fact]
            public void AddNumber_ValidNumber_NumberAddedSuccessfully()
            {
                // Arrange
                var line = new Lottoline();
                int numberToAdd = 10;

                // Act
                line.AddNumber(numberToAdd);

            // Assert
            _ = Assert.Equals(1, line.ChosenNumbers.Count);
            _ = Assert.ReferenceEquals(numberToAdd, line.ChosenNumbers);
            }

            [Fact]
            public void AddNumber_DuplicateNumber_ExceptionThrown()
            {
                // Arrange
                var line = new Lottoline();
                int numberToAdd = 10;

                // Act
                line.AddNumber(numberToAdd);

            // Assert
            _ = Assert.ThrowsException<InvalidOperationException>(() => line.AddNumber(numberToAdd));
            }

            // Add more test methods as needed to cover other scenarios for the Lottoline class
        }
    }
