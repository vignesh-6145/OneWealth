using Microsoft.EntityFrameworkCore;

using OneWealth.API.Middleware;
using OneWealth.Application;
using OneWealth.Infrastructure;
using OneWealth.Infrastructure.Data;
using OneWealth.Presentation;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DBCOntext
builder.Services.AddDbContext<OneWealthContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("OneWealth")));

//adding vatious projects dependencies
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddPresentation();
builder.Services.AddControllers();

//serilog
builder.Host.UseSerilog( (context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseMiddleware<RequestLogContextMiddleware>();
app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.Run();
// DONE Serilog, 
// DONE Configure Serilog best practices
//TODO Setup JWT
//TODO Setup unit tests
//DONE Add sonar code analsis
//TODO configure github actions
//DONE DB Design
//TODO EF Core
