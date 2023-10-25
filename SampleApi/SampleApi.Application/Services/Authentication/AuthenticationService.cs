using static System.Net.Mime.MediaTypeNames;

namespace SampleApi.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string fullName, string userName, string eamail, string password, string image);
    AuthenticationResult Login(string eamail, string password);
}

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),
                                        string.Empty,
                                        string.Empty,
                                        email,
                                        password,
                                        string.Empty,
                                        string.Empty);
    }

    public AuthenticationResult Register(string fullName, string userName, string email, string password, string image)
    {
        return new AuthenticationResult(Guid.NewGuid(),
                                        fullName,
                                        userName,
                                        email,
                                        password,
                                        image,
                                        string.Empty);
    }
}
