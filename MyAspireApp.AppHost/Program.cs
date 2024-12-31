using Aspire.Hosting;
using Aspire.Hosting.Redis;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MyAspireApp_ApiService>("apiservice");

// Add Redis
var redis = builder.AddRedis("cache")
        // Add custom repository
     .WithImage("repository/docker/redis","7.2.5");

// Add your Redis service and reference Redis
var redisService = builder.AddProject<Projects.MyAspireApp_RedisService>("redisService")
    .WithReference(redis);

builder.AddProject<Projects.MyAspireApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
