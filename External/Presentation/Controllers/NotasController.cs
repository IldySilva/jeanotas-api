
using Application.Login;
using Application.Usecases.Estudantes;
using Application.Usecases.Notas;
using Application.Usecases.Notas.GetNotas;
using Application.Usecases.Notas.LancarNota;
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
    [HttpPost]
    public async Task<IActionResult> Lancar(LancarNotaRequest request)
    {
        return Ok(await _sender.Send(request.Adapt<LancarNotaCommand>()));
    }
}