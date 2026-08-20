namespace Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

/// <summary>
/// A record representing the response for a greeting count request.
/// </summary>
/// <param name="GreetingCount">the number of greetings made to any developer.</param>
public record GetGreetingCountResponse(int GreetingCount);