
using Application.Login;
using Application.Usecases.Courses.GetCourses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[ApiController]
[Route(("api/escola"))]
public class EscolaController:ControllerBase
{
    private readonly ISender _sender;

    public EscolaController(ISender mediator)
    {
        _sender = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _sender.Send(new GetSchoolInfo()));
    }
}