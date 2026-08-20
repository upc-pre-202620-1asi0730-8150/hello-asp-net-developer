using Acme.Hello.Platform.Profiles.Domain.Model.Entities;
using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Tests.Profiles.Domain.Model.Entities;

public class DeveloperTests
{
    [Fact]
    public void Constructor_WithPersonName_InitializesIdAndName()
    {
        // Arrange
        var personName = new PersonName("John", "Doe");

        // Act
        var developer = new Developer(personName);

        // Assert
        Assert.NotEqual(Guid.Empty, developer.Id);
        Assert.Equal(personName, developer.Name);
        Assert.Equal("John Doe", developer.GetFullName());
        Assert.False(developer.IsAnyNameEmpty());
    }

    [Fact]
    public void Constructor_WithStrings_InitializesIdAndPersonName()
    {
        // Arrange & Act
        var developer = new Developer("John", "Doe");

        // Assert
        Assert.NotEqual(Guid.Empty, developer.Id);
        Assert.Equal(new PersonName("John", "Doe"), developer.Name);
        Assert.Equal("John Doe", developer.GetFullName());
        Assert.False(developer.IsAnyNameEmpty());
    }

    [Fact]
    public void Constructor_GeneratesUniqueIdsForInstances()
    {
        // Arrange & Act
        var dev1 = new Developer("John", "Doe");
        var dev2 = new Developer("John", "Doe");

        // Assert
        Assert.NotEqual(dev1.Id, dev2.Id);
    }

    [Fact]
    public void GetFullName_WithLeadingTrailingWhitespace_ReturnsTrimmedFullName()
    {
        // Arrange & Act
        var developer = new Developer("  John  ", "  Doe  ");

        // Assert
        Assert.Equal("John Doe", developer.GetFullName());
    }

    [Theory]
    [InlineData(null, "Doe")]
    [InlineData("", "Doe")]
    [InlineData("   ", "Doe")]
    [InlineData("John", null)]
    [InlineData("John", "")]
    [InlineData("John", "   ")]
    [InlineData(null, null)]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    public void IsAnyNameEmpty_WhenNamesAreEmptyOrWhitespace_ReturnsTrue(string? firstName, string? lastName)
    {
        // Arrange & Act
        var developer = new Developer(firstName!, lastName!);

        // Assert
        Assert.True(developer.IsAnyNameEmpty());
    }
}