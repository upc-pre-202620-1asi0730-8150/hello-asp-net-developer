using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Profiles.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity in the domain model with an auto-generated ID
/// and encapsulated name information.
/// </summary>
/// <param name="name">The developer's person name value object.</param>
public class Developer(PersonName name)
{
    /// <summary>
    /// Gets the unique identifier for the developer.
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();

    /// <summary>
    /// Gets the developer's person name value object.
    /// </summary>
    public PersonName Name { get; } = name;

    /// <summary>
    /// Initializes a new instance of the Developer class with first and last names.
    /// </summary>
    /// <param name="firstName">The developer's first name, which may be null or contain whitespace.</param>
    /// <param name="lastName">The developer's last name, which may be null or contain whitespace.</param>
    public Developer(string firstName, string lastName) : this(new PersonName(firstName, lastName))
    {
    }

    /// <summary>
    /// Returns the full name by delegating to the PersonName value object.
    /// </summary>
    /// <returns>The full name as a trimmed string.</returns>
    public string GetFullName() => Name.FullName;

    /// <summary>
    /// Checks if either the first name or last name is empty after trimming.
    /// </summary>
    /// <returns>True if any name is empty, false otherwise.</returns>
    public bool IsAnyNameEmpty() => Name.IsAnyNameEmpty();
}