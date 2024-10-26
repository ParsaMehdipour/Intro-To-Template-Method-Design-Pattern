// Deploy a web application
using DemoLibrary;
using DemoLibrary.ConcreteClasses;

Console.WriteLine("=== Starting Web Application Deployment ===");
var webDeployment = new WebAppDeploymentPipeline(
    "E-commerce Website",
    "2.1.0",
    DeploymentEnvironment.Production,
    "Nginx"
);
await webDeployment.ExecuteDeployment();

Console.WriteLine("\n=== Starting Microservice Deployment ===");
var microserviceDeployment = new MicroserviceDeploymentPipeline(
    "Payment Service",
    "1.3.2",
    DeploymentEnvironment.Production,
    "Kubernetes"
);
await microserviceDeployment.ExecuteDeployment();

Console.WriteLine("\n=== Starting Mobile App Deployment ===");
var mobileDeployment = new MobileAppDeploymentPipeline(
    "Shopping App",
    "3.0.1",
    DeploymentEnvironment.Production,
    "iOS"
);
await mobileDeployment.ExecuteDeployment();