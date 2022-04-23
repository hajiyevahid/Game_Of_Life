public class ConsoleWrapper : IConsoleWrapper
{
    public void WriteLine(string s)
    {
        Console.WriteLine(s);
    }
}