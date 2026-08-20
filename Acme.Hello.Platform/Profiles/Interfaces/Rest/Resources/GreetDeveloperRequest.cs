using JetBrains.Annotations;

namespace Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

/// <summary>
/// A record representing a request to greet a developer.
/// Contains the developer's first and last names, used as input for POST requests.
/// </summary>
/// <param name="FirstName">The developer's first name, which may be null.</param>
/// <param name="LastName">The developer's last name, which may be null.</param>
[UsedImplicitly]
public record GreetDeveloperRequest(string? FirstName, string? LastName)
{
    /// <summary>The developer's first name, which may be null.</summary>
    public string? FirstName { get; init; } = FirstName;
    /// <summary>The developer's last name, which may be null.</summary>
    public string? LastName { get; init; } = LastName;
}   