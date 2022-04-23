using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace UnitTesting
{
    [TestClass]
    public partial class EnableUserInputTest
    {
        [TestMethod]
        public void Starting_CorrectInput_CorrectOutput()
        {
            //Arrange
            var userinput = new EnableUserInput();
            string inp = "5";

            //Act
            var output = userinput.Starting(inp);

            //Assert
            Assert.IsTrue(int.Parse(inp) == output);
        }

        [TestMethod]
        public void Starting_OutputType_TypeOfByte()
        {
            //Arrange
            var userinput = new EnableUserInput();
            string inp = "5";

            //Act
            var output = userinput.Starting(inp);

            //Assert
            Assert.IsTrue(output.GetType() == typeof(int));
        }

        [TestMethod]
        //Assert
        [ExpectedException(typeof(System.Exception))]
        public void Starting_SizeIsNegative_ExceptionIsThrown()
        {
            //Arrange
            var input = new EnableUserInput();

            //Act
            input.Starting("-8");
        }

        [TestMethod]
        //Assert
        [ExpectedException(typeof(System.Exception))]
        public void Starting_SizeIsNull_ExceptionIsThrown()
        {
            //Arrange
            var input = new EnableUserInput();

            //Act
            input.Starting(null);
        }

        [TestMethod]
        //Assert
        [ExpectedException(typeof(System.Exception))]
        public void Starting_SizeIsOutOfBound_ExceptionIsThrown()
        {
            //Arrange
            var input = new EnableUserInput();

            //Act
            input.Starting("500");
        }
    }
}