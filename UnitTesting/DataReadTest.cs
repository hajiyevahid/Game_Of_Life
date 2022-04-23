using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class DataReadTest
    {
        [TestMethod]
        public void ReadData_ReadConsoleScreen_ReturnData()
        {
            // Arrange
            var mockConsoleReadline = new Mock<IConsoleWrapperRead>();
            mockConsoleReadline.Setup(x => x.ReadLine());
            var dataRead = new DataRead(mockConsoleReadline.Object);

            //Act
            dataRead.ReadData();

            //Assert
            mockConsoleReadline.Verify(t => t.ReadLine(), Times.Once());
        }
    }
}