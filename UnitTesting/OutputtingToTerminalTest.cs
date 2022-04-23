using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class OutputtingToTerminalTest
    {
        [TestMethod]
        public void Outputting_MatrixInput_CorrectOutputOfMatrix()
        {
            //Arrange
            var mockConsoleWriteLine = new Mock<IConsoleWrapper>();
            mockConsoleWriteLine.Setup(x => x.WriteLine(It.IsAny<string>()));



            int[,] matrix = new int[,] { { 1, 1, 0, 1 },
                                         { 1, 0, 0, 1 },
                                         { 0, 0, 0, 0 },
                                         { 1, 0, 0, 1 }
            };

            //Act
            OutputtingToTerminal outputtingToTerminal = new OutputtingToTerminal();
            outputtingToTerminal.Outputting(4, matrix);

            //Assert
            mockConsoleWriteLine.Verify(t => t.WriteLine("1 1 0 1\n" +
                                                         "        \n" +
                                                         "1 0 0 1\n" +
                                                         "        \n" +
                                                         "0 0 0 0\n" +
                                                         "        \n" +
                                                         "1 0 0 1\n" +
                                                         "-----------------"), Times.Never());
        }
    }
}