using Application.Messaging;
using Application.Models;

namespace Application.Usecases.Subjects.GetByProf;

public record GetSubjectByProfQuery(int Id,int Curso,string classe): IQuery<List<TbDisciplina>>;