using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Moq;
namespace UnitTesting
{
    public partial class EnableUserInputTest
    {
        [TestClass]
        public class DataDimension_Test
        {
            [TestMethod]
            public void FieldSize_CorrectConsoleOutput_PrintsData()
            {
                // Arrange
                var mockConsoleWriteLine = new Mock<IConsoleWrapper>();
                mockConsoleWriteLine.Setup(x => x.WriteLine(It.IsAny<string>()));
                var datadimension = new DataDimension(mockConsoleWriteLine.Object);

                // Act
                datadimension.FieldSize();

                // Assert
                mockConsoleWriteLine.Verify(t => t.WriteLine("Please enter the size of field. The size means the number of rows and columns in the square matrix (Column=Row): "), Times.Once());
            }
        }
    }
}