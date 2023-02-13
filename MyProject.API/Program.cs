using Microsoft.EntityFrameworkCore;
using MyProject.Context;
using MyProject.Repositories.Intefaces;
using MyProject.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddServices();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddDbContext<IContext, MyDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("corsPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
