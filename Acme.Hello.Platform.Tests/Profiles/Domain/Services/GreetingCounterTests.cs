using Acme.Hello.Platform.Profiles.Domain.Services.Internal;

namespace Acme.Hello.Platform.Tests.Profiles.Domain.Services;

public class GreetingCounterTests
{
    [Fact]
    public void InitialCount_IsZero()
    {
        // Arrange
        var counter = new GreetingCounter();

        // Act & Assert
        Assert.Equal(0, counter.Count);
    }

    [Fact]
    public void Increment_IncreasesCountByOne()
    {
        // Arrange
        var counter = new GreetingCounter();

        // Act
        counter.Increment();

        // Assert
        Assert.Equal(1, counter.Count);

        // Act
        counter.Increment();

        // Assert
        Assert.Equal(2, counter.Count);
    }

    [Fact]
    public void Increment_IsThreadSafeUnderConcurrentExecution()
    {
        // Arrange
        var counter = new GreetingCounter();
        const int numberOfThreads = 10;
        const int incrementsPerThread = 1000;

        // Act
        Task[] tasks =
        [
            .. Enumerable.Range(0, numberOfThreads)
                .Select(_ => Task.Run(() =>
                {
                    for (var j = 0; j < incrementsPerThread; j++) counter.Increment();
                }))
        ];

        Task.WaitAll(tasks);

        // Assert
        Assert.Equal(numberOfThreads * incrementsPerThread, counter.Count);
    }
}