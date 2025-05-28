using FluentValidation;

using Microsoft.EntityFrameworkCore;

using OneWealth.Business;
using OneWealth.Business.DTO.Profiles;
using OneWealth.Business.Validators;
using OneWealth.Repository;
using OneWealth.Repository.Data;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Host.UseSerilog( (context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));

//DBCOntext
builder.Services.AddDbContext<OneWealthContext>( options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("OneWealth"));
        options.EnableDetailedErrors(true);

    }
);

builder.Services.RegisterBusinessServices();
builder.Services.RegisterRepositories();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(UserRegistrationValidator));
builder.Services.AddAutoMapper(cfg => 
    cfg.AddProfile<UserProfile>());

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.Run();


//TODO : Add Docker support
//TODO : Add logging
//TODO : Add Serilog template
//TODO : Add EFCore 
//TODO : Configure CI Github actions
//TODO : JWT