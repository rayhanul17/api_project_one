namespace SampleApi.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FullName,
    string UserName,
    string Email,
    string Password,    
    string Token
);

