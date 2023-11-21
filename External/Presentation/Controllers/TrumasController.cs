
using Application.Login;
using Application.Usecases.Courses.GetCourses;
using Application.Usecases.Turmas;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/turmas"))]
public class TurmasController:ControllerBase
{
    private readonly ISender _sender;

    public TurmasController(ISender mediator)
    {
        _sender = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _sender.Send(new GetTurmasQuery()));
    }
}