namespace Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

/// <summary>
/// Represents a person's name as a value object in the domain model.
/// Encapsulates first and last names with trimming and formatting behavior.
/// </summary>
/// <param name="FirstName">The person's first name.</param>
/// <param name="LastName">The person's last name.</param>
public record PersonName(string FirstName, string LastName)
{
    /// <summary>
    /// Gets the first name, trimmed of whitespace.
    /// </summary>
    public string FirstName { get; } = string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName.Trim();

    /// <summary>
    /// Gets the last name, trimmed of whitespace.
    /// </summary>
    public string LastName { get; } = string.IsNullOrWhiteSpace(LastName) ? "" : LastName.Trim();

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
