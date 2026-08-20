namespace Acme.Hello.Platform.Profiles.Domain.Services.Internal;

/// <summary>
/// In-memory, thread-safe implementation of the <see cref="IGreetingCounter"/> service.
/// </summary>
public class GreetingCounter : IGreetingCounter
{
    private int _count;

    /// <inheritdoc />
    public int Count => Volatile.Read(ref _count);

    /// <inheritdoc />
    public void Increment() => Interlocked.Increment(ref _count);
}
