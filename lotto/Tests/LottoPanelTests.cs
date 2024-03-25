using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lotto.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lotto.Tests
    {
        [TestClass]
        public class LottoServiceTests
        {
            [TestMethod]
            public void GenerateRandomNumbers_ReturnsListOf6UniqueNumbers()
            {
                // Arrange
                LottoService LottoService = new LottoService();

                // Act
                List<int> randomNumbers = LottoService.GenerateRandomNumbers();

                // Assert
                Assert.IsNotNull(randomNumbers);
                Assert.AreEqual(6, randomNumbers.Count);

                // Ensure all numbers are unique
                CollectionAssert.AllItemsAreUnique(randomNumbers);
            }

            [TestMethod]
            public void IslineWinner_ReturnsTrueForWinningline()
            {
                // Arrange
                List<int> lineNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
                List<int> winningNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
                LottoService LottoService = new LottoService();

                // Act
                bool isWinner = LottoService.IslineWinner(lineNumbers, winningNumbers);

                // Assert
                Assert.IsTrue(isWinner);
            }

            [TestMethod]
            public void CalculateTotalTotal_ReturnsCorrectTotalTotal()
            {
                // Arrange
                int numberOflines = 3;
                decimal expectedTotal = 6; // 3 lines * 2 euro per line
                LottoService LottoService = new LottoService();

                // Act
                decimal totalTotal = LottoService.CalculateTotalTotal(numberOflines);

                // Assert
                Assert.AreEqual(expectedTotal, totalTotal);
            }
        }
    }

