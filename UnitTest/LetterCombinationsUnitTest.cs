using NUnit.Framework;
using Proekspert_Test;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestFixture]
    class LetterCombinationsUnitTest
    {
        private LetterCombinations letterCombinations;

        [SetUp]
        public void BaseSetUp()
        {
            letterCombinations = new LetterCombinations();
        }

        [Test]
        public void TestIfInputIsEmpty()
        {
            // Arrange
            int expected = 0;
            string input = "";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expected, result.Count);
        }

        [Test]
        public void TestIfInputContainsOnlyThreeLetterWord()
        {
            // Arrange
            int expected = 0;
            string input = "sun";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expected, result.Count);
        }

        [Test]
        public void TestIfInputContainsOnlyOneFourLetterWord()
        {
            // Arrange
            int expected = 1;
            string input = "hall";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expected, result.Count);
        }

        [Test]
        public void TestIfInputContainsTwoSameFourLetterWord()
        {
            // Arrange
            string expectedKey = "hall";
            decimal expectedValue = 66.67m;
            string input = "hall hall feel";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expectedKey, result.ElementAt(0).Key);
            Assert.AreEqual(expectedValue, result.ElementAt(0).Value);
        }

        [Test]
        public void TestIfInputContainsTwoDifferentFourLetterWord()
        {
            // Arrange
            string expectedFirstKey = "hall";
            string expectedSecondKey = "feel";
            decimal expectedValue = 50;
            string input = "hall feel";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expectedFirstKey, result.ElementAt(0).Key);
            Assert.AreEqual(expectedValue, result.ElementAt(0).Value);
            Assert.AreEqual(expectedSecondKey, result.ElementAt(1).Key);
            Assert.AreEqual(expectedValue, result.ElementAt(1).Value);
        }

        [Test]
        public void TestIfInputContainsMoreThanFourLetterWord()
        {
            // Arrange
            string expectedFirstKey = "hall";
            string expectedSecondKey = "alls";
            string expectedThirdKey = "halls";
            decimal expectedValue = 33.33m;
            string input = "halls";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expectedFirstKey, result.ElementAt(0).Key);
            Assert.AreEqual(expectedSecondKey, result.ElementAt(1).Key);
            Assert.AreEqual(expectedThirdKey, result.ElementAt(2).Key);
            Assert.AreEqual(expectedValue, result.ElementAt(0).Value);
        }

        [Test]
        public void TestIfInputContainsMoreThanTenLetterCombinations()
        {
            // Arrange
            int expected = 10;
            string input = "halls feels heel some words here more than ten";

            // Act
            Dictionary<string, decimal> result = letterCombinations.FindCommonLetterCombinations(input);

            // Assert
            Assert.AreEqual(expected, result.Count);
        }
    }
}
