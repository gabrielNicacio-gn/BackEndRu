using BackEndRu.src.Infrastruct;
using BackEndRu.src.UseCase;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IGetAllUsers, GetAllUsers>();

var app = builder.Build();

app.MapGet("/ru", ([FromServices] IGetAllUsers _getAll) =>
{
        var list = _getAll.Get();
        return list;
});

app.UseHttpsRedirection();
app.Run();
