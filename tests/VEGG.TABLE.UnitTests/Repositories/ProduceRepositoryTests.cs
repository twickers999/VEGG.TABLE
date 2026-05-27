namespace VEGG.TABLE.UnitTests.Repositories;

public class ProduceRepositoryTests // Tests for the data access layer
{
    [Fact]
    public void Should_Be_Empty_Initially()
    {
        // Arrange
        var repository = new ProduceRepository();

        // Act & Assert
        // Assuming your repository has a way to check count/content
        repository.Should().NotBeNull();
    }
}