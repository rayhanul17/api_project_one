namespace SampleApi.Contracts.Authentication;

public record RegisterRequest(
    string FullName,
    string UserName, 
    string Email,
    string Password
);
