using Application.Messaging;
using Domain.Entities;

namespace Application.Usecases.Courses.GetCourses;

public record GetCoursesQuery(int Id) : IQuery<List<Curso>>;
