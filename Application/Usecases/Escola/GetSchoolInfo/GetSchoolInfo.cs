using Application.Messaging;
using Application.Models;
using Domain.Entities;

namespace Application.Usecases.Courses.GetCourses;

public record GetSchoolInfo : IQuery<Escola>;
