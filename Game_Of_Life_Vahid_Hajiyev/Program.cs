using Microsoft.Extensions.DependencyInjection;
public class Program
{
    public static void Main()
    {
        var container = Dependency_Injection.ConfigureService();
        var start = container.GetRequiredService<EnableUserInput>();
        DataDimension dim = new DataDimension();
        dim.FieldSize();
        DataRead read = new DataRead();
        int dimension = start.Starting(read.ReadData());
        var matrix = container.GetRequiredService<MatrixSeeding>().Random(dimension);
        container.GetRequiredService<OutputtingToTerminal>().Outputting(dimension, matrix);
        var resultedMatrix = container.GetRequiredService<Logic>().Implement(dimension, matrix);
        while (true)
        {
            Console.Clear();    
            container.GetRequiredService<OutputtingToTerminal>().Outputting(dimension, resultedMatrix);
            resultedMatrix = container.GetRequiredService<Logic>().Implement(dimension, resultedMatrix);
            Thread.Sleep(1000);
        }
    }
}