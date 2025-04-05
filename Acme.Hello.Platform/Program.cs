using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


/// <summary>
// /// Defines the GET endpoint for retrieving a greeting.
// /// </summary>
// /// <param name="firstName">The optional first name of the developer.</param>
// /// <param name="lastName">The optional last name of the developer.</param>
// /// <returns>An IActionResult containing a GreetDeveloperResponse with a 200 OK status.</returns>
app.MapGet("/greetings", (string? firstName, string? lastName) =>
    {
        var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
            ? new Developer(firstName, lastName)
            : null;
        var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
        return Results.Ok(response);
    })
    .WithName("GetGreeting")
    .WithOpenApi();
    
// <summary>
// /// Defines the POST endpoint for creating a greeting.
// /// </summary>
// /// <param name="request">The GreetDeveloperRequest containing first and last names.</param>
// /// <returns>An IActionResult containing a GreetDeveloperResponse with a 201 Created status.</returns>
app.MapPost("/greetings", (GreetDeveloperRequest request) =>
    {
        var developer = DeveloperAssembler.ToEntityFromRequest(request);
        var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
        return Results.Created("/greetings", response);
    })
    .WithName("CreateGreeting")
    .WithOpenApi();

app.Run();