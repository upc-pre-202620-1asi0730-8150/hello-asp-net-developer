using Acme.Hello.Platform.Profiles.Domain.Services;
using Acme.Hello.Platform.Profiles.Interfaces.Rest.Assemblers;
using Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IGreetingCounter, GreetingCounter>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// <summary>
// /// Defines the GET endpoint for retrieving a greeting.
// /// </summary>
// /// <param name="firstName">The optional first name of the developer.</param>
// /// <param name="lastName">The optional last name of the developer.</param>
// /// <returns>An IActionResult containing a GetGreetingCountResponse with a 200 OK status.</returns>
app.MapGet("/api/v1/greetings", (IGreetingCounter greetingCounter) =>
    {
        var response = new GetGreetingCountResponse(greetingCounter.Count);
        return Results.Ok(response);
    })
    .WithName("GetGreetingCount")
    .WithSummary("Retrieves the count of greetings made to any developer.");
    
// <summary>
// /// Defines the POST endpoint for creating a greeting.
// /// </summary>
// /// <param name="request">The GreetDeveloperRequest containing first and last names.</param>
// /// <returns>An IActionResult containing a GreetDeveloperResponse with a 201 Created status.</returns>
app.MapPost("/api/v1/greetings", (GreetDeveloperRequest request, IGreetingCounter greetingCounter) =>
    {
        var developer = DeveloperAssembler.ToEntityFromRequest(request);
        if (developer != null)
        {
            greetingCounter.Increment();
        }
        var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
        return Results.Created("/api/v1/greetings", response);
    })
    .WithName("CreateGreeting")
    .Produces<GreetDeveloperResponse>(StatusCodes.Status201Created)
    .WithSummary("Creates a greeting for a developer.");

app.Run();