using DemoLibrary.AbstractClasses;

namespace DemoLibrary.ConcreteClasses;

/// <summary>
/// Concrete classes have to implement all abstract operations of the base
/// class. They can also override some operations with a default
/// implementation.
/// 
/// Concrete class for deploying web applications
/// </summary>
public class WebAppDeploymentPipeline : DeploymentPipeline
{
    private readonly string webServerType;

    public WebAppDeploymentPipeline(string projectName, string version,
        DeploymentEnvironment environment, string webServerType)
        : base(projectName, version, environment)
    {
        this.webServerType = webServerType;
    }

    protected override bool ValidateDeploymentRequirements()
    {
        Console.WriteLine("Validating web application requirements:");
        Console.WriteLine($"- Checking {webServerType} server configuration");
        Console.WriteLine("- Validating SSL certificates");
        Console.WriteLine("- Checking domain configurations");
        return true;
    }

    protected override async Task CompileCode()
    {
        Console.WriteLine("Compiling web application:");
        Console.WriteLine("- Processing TypeScript files");
        Console.WriteLine("- Bundling JavaScript");
        Console.WriteLine("- Minifying CSS");
        await Task.Delay(1000);
    }

    protected override async Task BuildArtifacts()
    {
        Console.WriteLine("Building web artifacts:");
        Console.WriteLine("- Creating production builds");
        Console.WriteLine("- Optimizing assets");
        Console.WriteLine("- Generating source maps");
        await Task.Delay(1000);
    }

    protected override async Task DeployArtifacts()
    {
        Console.WriteLine($"Deploying to {webServerType} server:");
        Console.WriteLine("- Copying static files");
        Console.WriteLine("- Updating web server configuration");
        await Task.Delay(1000);
    }

    protected override async Task ConfigureEnvironment()
    {
        Console.WriteLine("Configuring web environment:");
        Console.WriteLine("- Setting up application pool");
        Console.WriteLine("- Configuring virtual directories");
        Console.WriteLine("- Setting up URL rewrites");
        await Task.Delay(1000);
    }

    protected override async Task PerformHealthChecks()
    {
        Console.WriteLine("Performing web application health checks:");
        Console.WriteLine("- Checking homepage response");
        Console.WriteLine("- Validating API endpoints");
        Console.WriteLine("- Checking database connectivity");
        await Task.Delay(1000);
    }

    protected override async Task WarmupApplication()
    {
        Console.WriteLine("Warming up web application:");
        Console.WriteLine("- Priming application cache");
        Console.WriteLine("- Pre-loading common routes");
        await Task.Delay(1000);
    }
}