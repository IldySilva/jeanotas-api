using System.Data;
using System.Net.Mime;
using Domain.Repositories;
using Infraestructure.Infra_DbAcess;
using Microsoft.AspNetCore.Diagnostics;
using Persistence.Repositories;
using Web.Attributes.Middleware;

var builder = WebApplication.CreateBuilder(args);
{
    
}

builder.Services.AddCors(options =>
{

    options.AddPolicy(name: "CORS",
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
}); 
builder.Services.AddScoped<IDbConnection>(_ =>
    new Microsoft.Data.SqlClient.SqlConnection(builder.Configuration.GetConnectionString("DataSourceRemote"))); 
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepoProfessores, RepoProfessores>();
builder.Services.AddScoped<IRepoHorario, RepoHorario>();
builder.Services.AddScoped<IRepoEstudantes, RepoEstudantes>();
builder.Services.AddScoped<IRepoCursos, RepoCursos>();
builder.Services.AddScoped<IRepoDisciplinas, RepoDisciplina>();
builder.Services.AddScoped<IRepoNotas, RepoNotas>();
builder.Services.AddScoped<IRepoTurmas, RepoTurmas>();
builder.Services.AddScoped<IRepoSalas, RepoSalas>();

builder.Services.AddScoped<IDataAccess, DataAccess>();
builder.Services.AddTransient<ExceptionHandlingMiddleware>();
var presentationAssembly = typeof(Presentation.AssemblyReference).Assembly;
builder.Services.AddControllers()
    .AddApplicationPart(presentationAssembly);


builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(Application.AssemblyReference).Assembly));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseAuthorization();
app.UseCors("CORS");

app.MapControllers();

app.Run();