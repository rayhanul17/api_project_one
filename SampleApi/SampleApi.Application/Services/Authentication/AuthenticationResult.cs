using SampleApi.Domain.Entities;

namespace SampleApi.Application.Services.Authentication;

public record AuthenticationResult(
    User user,       
    string Token
);

