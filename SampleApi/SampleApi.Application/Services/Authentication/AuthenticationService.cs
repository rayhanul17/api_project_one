using SampleApi.Application.Common.Interfaces.Authentication;
using SampleApi.Application.Common.Interfaces.Persistance;
using SampleApi.Domain.Entities;

namespace SampleApi.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string fullName, string userName, string eamail, string password);
    AuthenticationResult Login(string eamail, string password);
}

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string fullName, string userName, string email, string password)
    {        
        if (_userRepository.GetUserByEmail(email) is not null)
            throw new Exception("User with given email already exist");

        var user = new User
        {
            FullName = fullName,
            UserName = userName,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user,                                       
                                        token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not User user)        
            throw new Exception("User with given email doesn't exist!");

        if (user.Password != password)
            throw new Exception("Invalid password");

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user,
                                        token);
    }

}
