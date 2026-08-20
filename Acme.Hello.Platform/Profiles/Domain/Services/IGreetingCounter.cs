namespace Acme.Hello.Platform.Profiles.Domain.Services;

/// <summary>
/// Domain service interface for tracking and retrieving greeting metrics.
/// </summary>
public interface IGreetingCounter
{
    /// <summary>
    /// Gets the current number of greetings made to any developer.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Increments the greeting count in a thread-safe manner.
    /// </summary>
    void Increment();
}
