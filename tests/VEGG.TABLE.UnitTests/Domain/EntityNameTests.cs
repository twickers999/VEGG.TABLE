namespace VEGG.TABLE.UnitTests.Domain;

public class UserTests // Tests for User, Table, and Produce logic
{
    [Fact]
    public void Should_Be_Able_To_Create_User()
    {
        // Arrange
        var user = new User
        {
            Name = "Khalos",
            Email = "khalos@example.com",
            Password = "SecurePassword123"
        };

        // Act & Assert
        user.Name.Should().Be("Khalos");
        user.Email.Should().Be("khalos@example.com");
    }
}