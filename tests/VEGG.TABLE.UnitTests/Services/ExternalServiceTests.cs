namespace VEGG.TABLE.UnitTests.Services;

public class ExternalServiceTests // Tests for the external API integration logic
{
    private readonly Mock<IHttpClientFactory> _httpClientFactoryMock = new();

    [Fact]
    public async Task Should_Return_Data_When_Api_Is_Successful()
    {
        // Arrange (Setup your mock here)

        // Act
        var result = "Success"; // Simulate your service call

        // Assert
        result.Should().NotBeNull()
              .And.Be("Success");
    }
}