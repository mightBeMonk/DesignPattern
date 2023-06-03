using Microsoft.Extensions.DependencyInjection;

// Register dependencies with DI container
var services = new ServiceCollection();
services.AddSingleton<LegacyLibrary>();
services.AddSingleton<Client>();
services.AddSingleton<ITarget, Adapter>();

// Create an instance of the client class
var serviceProvider = services.BuildServiceProvider();
var apiAdapter = serviceProvider.GetRequiredService<Client>();

// Use the client to perform operations
apiAdapter.MakeRequest();
Console.ReadLine();

public class LegacyLibrary
{
    public void SpecificRequest()
    {
        Console.WriteLine("LegacyLibrary: SpecificRequest called");
    }
}

// Target - Desired interface that the client expects
public interface ITarget
{
    void Request();
}

// Adapter - Adapts the interface of the Adaptee to the Target interface
public class Adapter : ITarget
{
    private readonly LegacyLibrary _legacyLibrary;

    public Adapter(LegacyLibrary legacyLibrary)
    {
        _legacyLibrary = legacyLibrary;
    }

    public void Request()
    {
        Console.WriteLine("Adapter: Request called, adapting to LegacyLibrary's SpecificRequest");
        _legacyLibrary.SpecificRequest();
    }
}

// Client - Uses the Target interface to interact with the Adaptee through the Adapter
public class Client
{
    private readonly ITarget _target;

    public Client(ITarget target)
    {
        _target = target;
    }

    public void MakeRequest()
    {
        _target.Request();
    }
}