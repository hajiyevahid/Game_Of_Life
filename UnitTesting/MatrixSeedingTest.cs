using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTesting
{
    [TestClass]
    public class MatrixSeedingTest
    {
        [TestMethod]
        public void Random_SeedingRandomValues_CorrectLengthOfMatrix()
        {
            //Arrange
            MatrixSeeding seeding = new MatrixSeeding();

            //Act
            var matrix = seeding.Random(3);

            //Assert
            Assert.AreEqual(9, matrix.Length);
        }

        [TestMethod]
        public void Random_SeedingRandomValues_ReturnNotNullElement()
        {
            //Arrange
            MatrixSeeding seeding = new MatrixSeeding();

            //Act
            var matrix = seeding.Random(18);

            //Assert
            foreach (var value in matrix)
            {
                Assert.IsTrue(value != null);
            }
        }

        [TestMethod]
        public void Random_SeedingRandomValues_ValuesAreNotOutOfBound()
        {
            //Arrange
            MatrixSeeding seeding = new MatrixSeeding();

            //Act
            var matrix = seeding.Random(18);

            //Assert
            foreach (var value in matrix)
            {
                Assert.IsTrue(value <= 1 && value >= 0);
            }
        }
    }
}