using Acme.Hello.Platform.Profiles.Domain.Model.Entities;
using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;
using Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

namespace Acme.Hello.Platform.Profiles.Interfaces.Rest.Assemblers;

/// <summary>
/// Assembler class to convert a GreetDeveloperRequest into a Developer entity.
/// Provides static methods for transforming REST request data into domain entities.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a GreetDeveloperRequest into a Developer entity.
    /// Returns null if the request is invalid (null or contains blank names).
    /// </summary>
    /// <param name="request">The request containing the first and last names may be null.</param>
    /// <returns>A Developer entity if the request is valid, null otherwise.</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null)
        {
            return null;
        }

        var personName = new PersonName(request.FirstName, request.LastName);
        if (personName.IsAnyNameEmpty())
        {
            return null;
        }

        return new Developer(personName);
    }
}