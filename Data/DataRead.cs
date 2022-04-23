public class DataRead
{
    private readonly IConsoleWrapperRead ConsoleWrapperRead;
    public DataRead()
    {
        ConsoleWrapperRead = new ConsoleWrapperRead();
    }
    public DataRead(IConsoleWrapperRead consoleWrapperRead)
    {
        ConsoleWrapperRead = consoleWrapperRead;
    }
    public string ReadData()
    {
        string data = ConsoleWrapperRead.ReadLine();
        return data;
    }
}