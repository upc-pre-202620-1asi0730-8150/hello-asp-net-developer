using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Tests.Profiles.Domain.Model.ValueObjects;

public class PersonNameTests
{
    [Fact]
    public void Constructor_WithValidNames_SetsPropertiesCorrectly()
    {
        // Arrange & Act
        var name = new PersonName("John", "Doe");

        // Assert
        Assert.Equal("John", name.FirstName);
        Assert.Equal("Doe", name.LastName);
        Assert.Equal("John Doe", name.FullName);
        Assert.False(name.IsAnyNameEmpty());
    }

    [Fact]
    public void Constructor_WithLeadingAndTrailingWhitespace_TrimsNames()
    {
        // Arrange & Act
        var name = new PersonName("  John  ", "  Doe  ");

        // Assert
        Assert.Equal("John", name.FirstName);
        Assert.Equal("Doe", name.LastName);
        Assert.Equal("John Doe", name.FullName);
        Assert.False(name.IsAnyNameEmpty());
    }

    [Fact]
    public void DefaultConstructor_InitializesWithEmptyStrings()
    {
        // Arrange & Act
        var name = new PersonName();

        // Assert
        Assert.Equal(string.Empty, name.FirstName);
        Assert.Equal(string.Empty, name.LastName);
        Assert.Equal(string.Empty, name.FullName);
        Assert.True(name.IsAnyNameEmpty());
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
    public void IsAnyNameEmpty_WhenEitherOrBothNamesAreEmptyOrWhitespace_ReturnsTrue(string? firstName, string? lastName)
    {
        // Arrange & Act
        var name = new PersonName(firstName!, lastName!);

        // Assert
        Assert.True(name.IsAnyNameEmpty());
    }

    [Fact]
    public void Equality_WithSameValues_AreEqual()
    {
        // Arrange
        var name1 = new PersonName("John", "Doe");
        var name2 = new PersonName("  John  ", "  Doe  ");

        // Act & Assert
        Assert.Equal(name1, name2);
        Assert.True(name1 == name2);
    }

    [Fact]
    public void Equality_WithDifferentValues_AreNotEqual()
    {
        // Arrange
        var name1 = new PersonName("John", "Doe");
        var name2 = new PersonName("Jane", "Doe");

        // Act & Assert
        Assert.NotEqual(name1, name2);
        Assert.True(name1 != name2);
    }
}
