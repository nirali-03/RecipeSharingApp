using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using App03.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<App03Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("App03Context") ?? throw new InvalidOperationException("Connection string 'App03Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<>();

builder.Services.AddCors(p=>p.AddPolicy(name: "corspolicy", build =>
{
    build.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    //.WithExposedHeaders("Content-Disposition");
    //build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("Content-Disposition");

}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
