namespace Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

/// <summary>
/// Represents a person's name as a value object in the domain model.
/// Encapsulates first and last names with trimming and formatting behavior.
/// </summary>
public readonly record struct PersonName
{
    /// <summary>
    /// Gets the first name, trimmed of whitespace.
    /// </summary>
    public string? FirstName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
    }

    /// <summary>
    /// Gets the last name, trimmed of whitespace.
    /// </summary>
    public string? LastName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
    }

    /// <summary>
    /// Initializes a new instance of PersonName with first and last names.
    /// </summary>
    /// <param name="firstName">The person's first name.</param>
    /// <param name="lastName">The person's last name.</param>
    public PersonName(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    /// <summary>
    /// Initializes a new instance of PersonName with empty names.
    /// </summary>
    public PersonName() : this(string.Empty, string.Empty)
    {
    }

    /// <summary>
    /// Returns the full name by concatenating first and last names with a space.
    /// </summary>
    /// <returns>The full name as a trimmed string.</returns>
    public string FullName => $"{FirstName} {LastName}".Trim();

    /// <summary>
    /// Checks if either the first name or last name is empty after trimming.
    /// </summary>
    /// <returns>True if any name is empty, false otherwise.</returns>
    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
}
