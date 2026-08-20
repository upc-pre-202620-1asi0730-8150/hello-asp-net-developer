using Acme.Hello.Platform.Profiles.Domain.Model.Entities;

namespace Acme.Hello.Platform.Profiles.Interfaces.Rest.Resources;

public record GetGreetingCountResponse(int GreetingCount)
{
    public GetGreetingCountResponse() : this(Developer.GreetingCount) { }
}