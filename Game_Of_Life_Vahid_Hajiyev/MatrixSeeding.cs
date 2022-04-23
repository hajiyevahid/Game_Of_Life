public class MatrixSeeding
{
    public  int[,] Random(int size)
    {
        int[,] matrix = new int[size, size];
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                Random random = new Random();
                int rnd = random.Next(2);
                matrix[row, column] = rnd;
            }
        }

        return matrix;
    }
}