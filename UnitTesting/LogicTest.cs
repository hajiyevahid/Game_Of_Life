using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTesting
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void CountNeighbours_CorrectInputDetails_ReturnSumOfNeighbours()
        {
            // Arrange
            int[,] matrix = new int[,] {{ 1, 1, 0 },
                                        { 1, 0, 0 },
                                        { 0, 0, 0 }
            };
            int row = 1;
            int col = 1;
            int dimension = 3;

            //Act
            var neighbours = Logic.CountNeighbours(matrix, row, col, dimension);

            //Assert
            Assert.AreEqual(3, neighbours);
        }

        [TestMethod]
        public void Implement_CorrectInputDetails_ReturnResultedMatrix()
        {
            // Arrange
            int[,] matrix = new int[,] {{ 1, 1, 1 },
                                        { 0, 1, 1 },
                                        { 0, 1, 0 }
            };

            int[,] implemented = new int[,] {{ 0, 0, 0 },
                                             { 0, 0, 0 },
                                             { 0, 0, 0 }
            };

            int dimension = 3;

            //Act
            Logic logic = new Logic();
            var implement = logic.Implement(dimension, matrix);

            //Assert
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Assert.AreEqual(implemented[i, j], implement[i, j]);
                }
            }
        }
    }
}