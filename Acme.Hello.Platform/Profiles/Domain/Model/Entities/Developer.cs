using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Profiles.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity in the domain model with an auto-generated ID
/// and encapsulated name information.
/// </summary>
public class Developer
{
    /// <summary>
    /// Gets the unique identifier for the developer.
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();

    /// <summary>
    /// Gets the developer's person name value object.
    /// </summary>
    public PersonName Name { get; }

    /// <summary>
    /// Gets or sets the number of greetings made to any developer. 
    /// </summary>
    public static int GreetingCount { get; private set; } = 0;
    
    /// <summary>
    /// Initializes a new instance of the Developer class with a PersonName value object.
    /// </summary>
    /// <param name="name">The developer's person name.</param>
    public Developer(PersonName name)
    {
        Name = name;
    }

    /// <summary>
    /// Initializes a new instance of the Developer class with first and last names.
    /// </summary>
    /// <param name="firstName">The developer's first name, may be null or contain whitespace.</param>
    /// <param name="lastName">The developer's last name, may be null or contain whitespace.</param>
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
    
    /// <summary>
    /// Increments the greeting count for this developer.
    /// </summary>
    public void IncrementGreetingCount() => GreetingCount++;
}