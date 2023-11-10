
using Application.Login;
using Application.Usecases.Subjects.GetByProf;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/disciplinas"))]
public class DisciplinaController:ControllerBase
{
    private readonly ISender _sender;

    public DisciplinaController(ISender mediator)
    {
        _sender = mediator;
    }
       
    [HttpGet("{professor}")]
    public async Task<IActionResult> GetByProf(int professor)
    {
        return Ok(await _sender.Send(new GetSubjectByProfQuery(professor)));
    }
}