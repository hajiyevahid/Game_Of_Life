public class DataSize
{
    private readonly IConsoleWrapper ConsoleWrapper;
    public DataSize()
    {
        ConsoleWrapper = new ConsoleWrapper();
    }
    public DataSize(IConsoleWrapper consoleWrapper)
    {
        ConsoleWrapper = consoleWrapper;
    }
    public  void PleaseEnter()
    {
        ConsoleWrapper.WriteLine("Please enter a valid dimension size !");
    }
}