using Newtonsoft.Json;
using RestAPI.Model.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SampleRestApiContext>();

var app = builder.Build();

//Here , We Make a Simple API 

#region Simple API
app.MapGet("/GetProductList", async (HttpContext ctx, SampleRestApiContext dbcontext) =>
{
var productList = dbcontext.Products.ToList();
var productliststring = JsonConvert.SerializeObject(productList);

ctx.Response.StatusCode = 200;
ctx.Response.ContentType = "application/json";
await ctx.Response.WriteAsync(productliststring);

}); 
#endregion

app.MapGet("/", () => "Hello World!");

app.Run();
