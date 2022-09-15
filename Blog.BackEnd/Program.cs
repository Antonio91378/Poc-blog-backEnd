using API.Blog.BackEnd.ConfigExtensions;
using API.Blog.BackEnd.Infra.Contexts;
using Blog.Domain.Interfaces;
using Blog.Service;
using Blog.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IPostService, PostService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context2>(options =>
        options.UseSqlServer(ApplicationSettings.GetConnectionStringEntity()));

var app = builder.Build();

app.MapControllers();
app.UseSwagger();


app.UseSwaggerUI(c =>
{
    c.RoutePrefix = "";
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

DataBaseManagementService.MigrationInitialisation(app);

app.UseHttpsRedirection();
app.UseAuthorization();
app.Run();