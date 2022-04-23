public class ConsoleWrapperMatrix : IConsoleWrapperMatrix
{
    public void Write(string s)
    {
        Console.Write(s);
    }
}