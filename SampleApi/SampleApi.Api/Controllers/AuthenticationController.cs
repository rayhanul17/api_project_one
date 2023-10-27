using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Application.Services.Authentication;
using SampleApi.Contracts.Authentication;

namespace SampleApi.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {        
        var authResult = _authenticationService.Register(request.FullName,
                                                         request.UserName,
                                                         request.Email,
                                                         request.Password);
        
        var response = new AuthenticationResponse(authResult.Id,
                                                  authResult.FullName,
                                                  authResult.UserName,
                                                  authResult.Email,
                                                  authResult.Password,
                                                  authResult.Token);
        
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(request.Email,
                                                      request.Password);

        var response = new AuthenticationResponse(authResult.Id,
                                                  authResult.FullName,
                                                  authResult.UserName,
                                                  authResult.Email,
                                                  authResult.Password,
                                                  authResult.Token);
        return Ok(response);
    }
}
