using Acme.Hello.Platform.Profiles.Domain.Services;
using Acme.Hello.Platform.Profiles.Interfaces.Rest.Assemblers;
using Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

namespace Acme.Hello.Platform.Profiles.Interfaces.Rest;

/// <summary>
/// Extension methods for mapping greeting REST endpoints.
/// </summary>
public static class GreetingEndpoints
{
    /// <summary>
    /// Maps the greeting endpoints to the specified endpoint route builder.
    /// </summary>
    /// <param name="app">The endpoint route builder.</param>
    /// <returns>The endpoint route builder for chaining.</returns>
    public static IEndpointRouteBuilder MapGreetingEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/greetings")
            .WithTags("Greetings");

        group.MapGet("", (IGreetingCounter greetingCounter) =>
            {
                var response = new GetGreetingCountResponse(greetingCounter.Count);
                return Results.Ok(response);
            })
            .WithName("GetGreetingCount")
            .Produces<GetGreetingCountResponse>()
            .WithSummary("Retrieves the count of greetings made to any developer.");

        group.MapPost("", (GreetDeveloperRequest request, IGreetingCounter greetingCounter) =>
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

        return app;
    }
}
