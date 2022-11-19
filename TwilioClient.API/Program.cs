using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TwilioClient.API.Validators;
using TwilioClient.Common.Extensions;
using TwilioClient.Data;

var builder = WebApplication.CreateBuilder(args);

// Register all services using extension method
builder.Services.RegisterServices();

// Add auto validation
builder.Services.AddFluentValidationAutoValidation();
// Register all validators
builder.Services.AddValidatorsFromAssemblyContaining<SMSModelValidator>();

// Add configuration with appsettings.json file
IConfiguration configuration = new ConfigurationBuilder()
   .AddJsonFile("appsettings.json", true, true)
   .Build();

// Register AppDbContext
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly("WebApplication1.Migrations")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
