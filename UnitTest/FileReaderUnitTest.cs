using System.IO;
using System.Reflection;
using NUnit.Framework;
using Proekspert_Test;

namespace UnitTest
{
    [TestFixture]
    class FileReaderUnitTest
    {
       
        private FileReader fileReader;

        [SetUp]
        public void BaseSetUp()
        {
            fileReader = new FileReader();
        }
        
        [Test]
        public void TestIfFileIsEmpty()
        {
            // Arrange
            var currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", string.Empty);
            string filePath = Path.Combine(currentAssemblyPath, @"testFiles\emptyFile.txt");
            string expectedInput = "";

            // Act
            string input = fileReader.GetInputFromFile(filePath);

            // Assert
            Assert.AreEqual(expectedInput, input);
        }

        [Test]
        public void TestIfInputContainsPunctuation()
        {
            // Arrange
            var currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", string.Empty);
            string filePath = Path.Combine(currentAssemblyPath, @"testFiles\testWithPunctuations.txt");
            string expectedInput = "some word here";

            // Act
            string input = fileReader.GetInputFromFile(filePath);

            // Assert
            Assert.AreEqual(expectedInput, input);
        }
    }
}
