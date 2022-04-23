using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class DataSizeTest
    {
        [TestMethod]
        public void PleaseEnter_CorrectConsoleOutput_PrintsMessage()
        {
            // Arrange
            var mockConsoleWriteLine = new Mock<IConsoleWrapper>();
            mockConsoleWriteLine.Setup(x => x.WriteLine(It.IsAny<string>()));
            var datasize = new DataSize(mockConsoleWriteLine.Object);

            // Act
            datasize.PleaseEnter();

            // Assert
            mockConsoleWriteLine.Verify(t => t.WriteLine("Please enter a valid dimension size !"), Times.Once());
        }
    }
}
