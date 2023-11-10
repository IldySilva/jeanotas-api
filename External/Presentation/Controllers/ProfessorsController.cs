
using Application.Usecases.Perfil.MudarCredencias;
using Application.Usecases.Perfil.MudarSenha;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/professors"))]
public class ProfessorsController:ControllerBase
{
    private readonly ISender _sender;

    public ProfessorsController(ISender mediator)
    {
        _sender = mediator;
    }
    [HttpPut("username")]
    public async Task<IActionResult> MudarNome(MudarCredenciaisCommand request)
    {
        return Ok(await _sender.Send(request));
    }    
    [HttpPut("password")]
    public async Task<IActionResult> MudarSenha(MudarSenhaCommand request)
    {
        return Ok(await _sender.Send(request));
    }
}