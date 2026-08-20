namespace Acme.Hello.Platform.Profiles.Interfaces.REST.Resources;

/// <summary>
/// A record representing the response for a greeting request.
/// Contains the developer's ID, full name, and a personalized message, used as output for GET and POST responses.
/// </summary>
/// <param name="Id">The unique identifier of the developer, may be null for anonymous responses.</param>
/// <param name="FullName">The full name of the developer, may be null for anonymous responses.</param>
/// <param name="Message">The greeting message.</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Constructs a response with only a message, used for anonymous greetings.
    /// </summary>
    /// <param name="message">The greeting message, typically for anonymous cases.</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
}