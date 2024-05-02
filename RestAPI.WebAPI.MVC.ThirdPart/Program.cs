using Microsoft.Extensions.DependencyInjection;
using RestAPI.Model.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SampleRestApiContext>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();


app.Run();
 