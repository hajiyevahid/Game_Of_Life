public class ConsoleWrapperRead : IConsoleWrapperRead
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}