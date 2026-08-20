using Acme.Hello.Platform.Profiles.Domain.Services;
using Acme.Hello.Platform.Profiles.Domain.Services.Internal;
using Acme.Hello.Platform.Profiles.Interfaces.Rest;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IGreetingCounter, GreetingCounter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithTitle("ACME Hello ASP.NET Core API")
               .WithTheme(ScalarTheme.DeepSpace)
               .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });
}

app.MapGreetingEndpoints();

app.Run();