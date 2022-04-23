using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataDimension
{
    private readonly IConsoleWrapper ConsoleWrapper;

    public DataDimension()
    {
        ConsoleWrapper = new ConsoleWrapper();
    }

    public DataDimension(IConsoleWrapper consoleWrapper)
    {
        ConsoleWrapper = consoleWrapper;
    }
    public void FieldSize()
    {
        ConsoleWrapper.WriteLine("Please enter the size of field. The size means the number " +
                                  "of rows and columns in the square matrix (Column=Row): ");
    }
}
