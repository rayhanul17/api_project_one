using SampleApi.Domain.Entities;

namespace SampleApi.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
