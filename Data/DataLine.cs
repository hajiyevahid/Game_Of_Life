public  class DataLine
{
    private readonly IConsoleWrapper ConsoleWrapper;
    public DataLine()
    {
        ConsoleWrapper = new ConsoleWrapper();
    }
    public DataLine(IConsoleWrapper consoleWrapper)
    {
        ConsoleWrapper = consoleWrapper;
    }
    public void Line()
    {
        ConsoleWrapper.WriteLine("-----------------");
    }
}