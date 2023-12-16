using Application.Messaging;
using Application.Models;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Usecases.Courses.GetCourses;

public class GetSchoolInfoQueryHandler:IQueryHandler<GetSchoolInfo,Escola>
{

    private readonly IRepoSchool _school;

    public GetSchoolInfoQueryHandler(IRepoSchool school)
    {
        _school = school;
    }

    public async Task<Escola> Handle(GetSchoolInfo request, CancellationToken cancellationToken)
    {
        return await _school.Get();
    }
};