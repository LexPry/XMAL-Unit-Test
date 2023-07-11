using Moq;
using Project;

namespace UTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Should_Return_Expected_Greeting_When_Name_Length_Is_Greater_Than_0()
    {
        // Arrange
        const string validName = "Buddy";
        const string expectedGreeting = "Hello Buddy";

        var loginServiceMock = new Mock<IUserLoginService>();
        loginServiceMock.Setup(l => l.GreetUser(validName)).Returns(expectedGreeting);
        var loginService = loginServiceMock.Object;

        // Act
        var actualGreeting = loginService.GreetUser(validName);

        // Assert
        loginServiceMock.Verify(l => l.GreetUser(validName), Times.Once);
        Assert.That(actualGreeting, Is.EqualTo(expectedGreeting), "The user greeting is incorrect");
    }
}