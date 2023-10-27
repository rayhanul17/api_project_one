using SampleApi.Application.Common.Interfaces.Authentication;
using static System.Net.Mime.MediaTypeNames;

namespace SampleApi.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string fullName, string userName, string eamail, string password);
    AuthenticationResult Login(string eamail, string password);
}

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string fullName, string userName, string email, string password)
    {
        //Check if user already exist

        //Create user

        //Genereate Jwt token
        var userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId, email, password);

        return new AuthenticationResult(userId,
                                        fullName,
                                        userName,
                                        email,
                                        password,
                                        token);
    }

    public AuthenticationResult Login(string email, string password)
    {      

        return new AuthenticationResult(Guid.NewGuid(),
                                        string.Empty,
                                        string.Empty,
                                        email,
                                        password,                                        
                                        string.Empty);
    }
    
}
