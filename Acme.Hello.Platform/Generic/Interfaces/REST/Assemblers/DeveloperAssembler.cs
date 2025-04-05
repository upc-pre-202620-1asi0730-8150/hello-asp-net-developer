namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

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
        if (request == null || string.IsNullOrWhiteSpace(request.FirstName) || string.IsNullOrWhiteSpace(request.LastName))
        {
            return null;
        }
        return new Developer(request.FirstName, request.LastName);
    }
}