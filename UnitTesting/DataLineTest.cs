using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class DataLineTest
    {
        [TestMethod]
        public void Line_CorrectConsoleOutput_PrintsLine()
        {
            // Arrange
            var mockConsoleWriteLine = new Mock<IConsoleWrapper>();
            mockConsoleWriteLine.Setup(x => x.WriteLine(It.IsAny<string>()));
            var dataLine = new DataLine(mockConsoleWriteLine.Object);

            // Act
            dataLine.Line();

            // Assert
            mockConsoleWriteLine.Verify(t => t.WriteLine("-----------------"), Times.Once());
        }
    }
}