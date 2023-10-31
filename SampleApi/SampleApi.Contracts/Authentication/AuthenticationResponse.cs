namespace SampleApi.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FullName,
    string UserName,
    string Email,
    string Token
);
