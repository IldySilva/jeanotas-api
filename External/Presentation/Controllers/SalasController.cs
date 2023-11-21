
using Application.Login;
using Application.Usecases.Courses.GetCourses;
using Application.Usecases.Turmas;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/salas"))]
public class SalasController:ControllerBase
{
    private readonly ISender _sender;

    public SalasController(ISender mediator)
    {
        _sender = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _sender.Send(new GetSalasQuery()));
    }
}