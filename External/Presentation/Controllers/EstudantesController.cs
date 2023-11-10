
using Application.Login;
using Application.Usecases.Estudantes;
using Application.Usecases.Subjects.GetByProf;
using Application.Usecases.Turmas;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/estudantes"))]
public class EstudantesController:ControllerBase
{
    private readonly ISender _sender;

    public EstudantesController(ISender mediator)
    {
        _sender = mediator;
    }
       
    [HttpPost]
    public async Task<IActionResult> GetByProf(GetEstudantesRequest filter)
    {
        return Ok(await _sender.Send(filter.Adapt<GetEstudantesQuery>()));
    }
    

}