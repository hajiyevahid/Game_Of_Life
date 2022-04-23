public class OutputtingToTerminal
{
    private readonly IConsoleWrapperMatrix ConsoleWrapperMatrix;
    private readonly IConsoleWrapper ConsoleWrapper;

    public OutputtingToTerminal()
    {
        ConsoleWrapperMatrix = new ConsoleWrapperMatrix();
        ConsoleWrapper = new ConsoleWrapper();
    }

    public OutputtingToTerminal(IConsoleWrapperMatrix consoleWrapperMatrix, IConsoleWrapperMatrix consoleWrapper)
    {
        ConsoleWrapperMatrix = consoleWrapperMatrix;
        ConsoleWrapper = ConsoleWrapper;
    }
    public void Outputting(int dimension, int[,] matrix)
    {
        for (int row = 0; row < dimension; row++)
        {
            ConsoleWrapper.WriteLine("");
            for (int column = 0; column < dimension; column++)
            {
                ConsoleWrapperMatrix.Write(matrix[row, column] + " ");
            }
            ConsoleWrapper.WriteLine("");
        }
        DataLine dataLine = new DataLine();
        dataLine.Line();
    }
}