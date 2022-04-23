public class Logic
{
    public int[,] Implement(int dimension, int[,] matrix)
    {
        int[,] result = new int[dimension, dimension];
        for (int row = 0; row < dimension; row++)
        {
            for (int column = 0; column < dimension; column++)
            {
                var current = matrix[row, column];
                var neighboursCount = CountNeighbours(matrix, row, column, dimension);

                if (current == 0 && neighboursCount == 3)
                {
                    result[row, column] = 1;
                }
                else if (current == 1 && (neighboursCount < 2 || neighboursCount > 3))
                {
                    result[row, column] = 0;

                }
                else
                {
                    result[row, column] = current;
                }
            }
        }

        return result;
    }

    public static int CountNeighbours(int[,] field, int row, int column, int dimensions)
    {
        int sumNeighbours = 0;
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                int rows = (row + i + dimensions) % dimensions;
                int columns = (column + j + dimensions) % dimensions;
                sumNeighbours += field[rows, columns];
            }
        }
        sumNeighbours -= field[row, column];

        return sumNeighbours;
    }
}