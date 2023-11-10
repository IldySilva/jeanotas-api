using Application.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route("api/auth")]
public class AuthController:ControllerBase
{

    private readonly ISender _sender;

    public AuthController(ISender mediator)
    {
        _sender = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> LoginProfessor(LoginRequest request)
    {
        return Ok(await _sender.Send(new LoginCommand(request.User, request.Password)));
    }
}