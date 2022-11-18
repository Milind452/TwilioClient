using FluentValidation;
using FluentValidation.AspNetCore;
using TwilioClient.API.Validators;
using TwilioClient.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Register all services using extension method
builder.Services.RegisterServices();

// Add auto validation
builder.Services.AddFluentValidationAutoValidation();
// Register all validators
builder.Services.AddValidatorsFromAssemblyContaining<SMSModelValidator>();

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
