
using Application.Login;
using Application.Usecases.Horarios;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/horarios"))]
public class HorarioController:ControllerBase
{
    private readonly ISender _sender;

    public HorarioController(ISender mediator)
    {
        _sender = mediator;
    }
    
    [HttpGet("{professor}")]
    public async Task<IActionResult> GetHorario(int professor)
    {
        return Ok(await _sender.Send(new GetHorarioQuery(professor)));
    }
 
}