
using Application.Login;
using Application.Usecases.Horarios;
using Application.Usecases.Subjects.GetByProf;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/faltas"))]
public class FaltasController:ControllerBase
{
    private readonly ISender _sender;

    public FaltasController(ISender mediator)
    {
        _sender = mediator;
    }
       
    [HttpGet("{professor}")]
    public async Task<IActionResult> GetByProf(int professor)
    {
        return Ok(await _sender.Send(new GetFaltasQuery(professor)));
    }
}