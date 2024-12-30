# .Net-Aspire
Aspire is a toolset for setting up and running .NET projects efficiently, typically used in enterprise environments to enforce consistent project standards

1-First, ensure you have the prerequisites:
Install .NET 8 SDK (or later)
Install Visual Studio 2022 17.9 or later (optional, you can use VS Code or command line)

2-Install the .NET Aspire workload. Open a terminal and run:dotnet workload install aspire

3-Create a new Aspire application using the template:dotnet new aspire-starter --name MyAspireApp
 The template will create several projects:
    MyAspireApp.AppHost: The orchestration project
    MyAspireApp.ServiceDefaults: Shared service configuration
    MyAspireApp.ApiService: An example API service
    MyAspireApp.Web: A front-end web application

4-Add to launchSettings.json:
You can also add this to your AppHost project's Properties/launchSettings.json:
"ASPNETCORE_URLS": "http://localhost:15888"

5-Build and run the solution:
cd MyAspireApp
dotnet build
dotnet run --project MyAspireApp.AppHost