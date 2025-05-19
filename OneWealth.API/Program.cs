using Microsoft.EntityFrameworkCore;

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

var app = builder.Build();


//DBCOntext
builder.Services.AddDbContext<OneWealthContext>( options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("OneWealth"));
        options.EnableDetailedErrors(true);

    }
);

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