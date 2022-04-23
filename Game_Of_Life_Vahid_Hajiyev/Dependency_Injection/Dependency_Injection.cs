using Microsoft.Extensions.DependencyInjection;
public static class Dependency_Injection
{
    public static IServiceProvider ConfigureService()
    {
        var provider = new ServiceCollection()
            .AddSingleton<EnableUserInput>()
            .AddSingleton<MatrixSeeding>()
            .AddSingleton<Logic>()
            .AddSingleton<OutputtingToTerminal>()
            .BuildServiceProvider();

        return provider;
    }
}

