using DemoLibrary.AbstractClasses;

namespace DemoLibrary.ConcreteClasses;

/// <summary>
/// Concrete classes have to implement all abstract operations of the base
/// class. They can also override some operations with a default
/// implementation.
/// 
/// Concrete class for deploying mobile applications
/// </summary>
public class MobileAppDeploymentPipeline : DeploymentPipeline
{
    private readonly string platform; // iOS or Android

    public MobileAppDeploymentPipeline(string projectName, string version,
        DeploymentEnvironment environment, string platform)
        : base(projectName, version, environment)
    {
        this.platform = platform;
    }

    protected override bool ValidateDeploymentRequirements()
    {
        Console.WriteLine($"Validating {platform} requirements:");
        Console.WriteLine("- Checking signing certificates");
        Console.WriteLine("- Validating provisioning profiles");
        Console.WriteLine("- Verifying app store credentials");
        return true;
    }

    protected override async Task RunSecurityScans()
    {
        await base.RunSecurityScans();
        Console.WriteLine("Running mobile-specific security scans:");
        Console.WriteLine("- Checking for API key exposure");
        Console.WriteLine("- Validating app permissions");
    }

    protected override async Task CompileCode()
    {
        Console.WriteLine($"Compiling {platform} application:");
        Console.WriteLine("- Processing native code");
        Console.WriteLine("- Compiling resources");
        await Task.Delay(1000);
    }

    protected override async Task BuildArtifacts()
    {
        Console.WriteLine($"Building {platform} artifacts:");
        Console.WriteLine("- Creating release build");
        Console.WriteLine("- Signing application");
        Console.WriteLine("- Generating app bundle");
        await Task.Delay(1000);
    }

    protected override async Task DeployArtifacts()
    {
        Console.WriteLine($"Deploying to {platform} store:");
        Console.WriteLine("- Uploading app bundle");
        Console.WriteLine("- Submitting for review");
        Console.WriteLine("- Updating store metadata");
        await Task.Delay(1000);
    }

    protected override async Task ConfigureEnvironment()
    {
        Console.WriteLine("Configuring mobile environment:");
        Console.WriteLine("- Setting up push notifications");
        Console.WriteLine("- Configuring analytics");
        Console.WriteLine("- Setting up crash reporting");
        await Task.Delay(1000);
    }

    protected override async Task PerformHealthChecks()
    {
        Console.WriteLine("Performing mobile app health checks:");
        Console.WriteLine("- Validating API connectivity");
        Console.WriteLine("- Checking push notification setup");
        Console.WriteLine("- Verifying analytics integration");
        await Task.Delay(1000);
    }

    protected override bool RequiresWarmup()
    {
        return false; // Mobile apps don't need warmup
    }
}
