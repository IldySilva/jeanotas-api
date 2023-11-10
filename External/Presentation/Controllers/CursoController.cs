
using Application.Login;
using Application.Usecases.Courses.GetCourses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/curso"))]
public class CursoController:ControllerBase
{
    private readonly ISender _sender;

    public CursoController(ISender mediator)
    {
        _sender = mediator;
    }
    [HttpGet("{professor}")]
    public async Task<IActionResult> GetByProf(int professor)
    {
        return Ok(await _sender.Send(new GetCoursesQuery(professor)));
    }
}