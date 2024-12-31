using Aspire.Hosting;
using Aspire.Hosting.Redis;

var builder = DistributedApplication.CreateBuilder(args);

// Add Redis
var cache = builder.AddRedis("cache")
        // Add custom repository
     .WithImage("repository/docker/redis","7.2.5");

// Add your Redis service and reference Redis
builder.AddProject<Projects.MyAspireApp_RedisService>("redisService")
    .WithReference(cache);


builder.Build().Run();
