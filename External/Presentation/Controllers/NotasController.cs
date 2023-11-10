
using Application.Login;
using Application.Usecases.Estudantes;
using Application.Usecases.Notas.GetNotas;
using Application.Usecases.Subjects.GetByProf;
using Application.Usecases.Turmas;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/notas"))]
public class NotasController:ControllerBase
{
    private readonly ISender _sender;

    public NotasController(ISender mediator)
    {
        _sender = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetNotas(int id)
    {
        return Ok(await _sender.Send(new GetNotasQuery(id)));
    }
}