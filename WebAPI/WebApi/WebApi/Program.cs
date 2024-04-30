using WebApi.Service;
using WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IitemsInterface>(provider =>
{
    var filePath = "C:\\Users\\waleed\\OneDrive\\Documents\\GitHub\\Ecommerce_Project\\WebAPI\\WebApi\\WebApi\\itemsfile.json"; //download json file and type your own path
    return new ItemsService(filePath);
});

builder.Services.AddScoped<UserdataInterface>(provider =>
{
    var filePath = "C:\\Users\\waleed\\OneDrive\\Documents\\GitHub\\Ecommerce_Project\\WebAPI\\WebApi\\WebApi\\userdata.json"; //download json file and type your own path
    return new UserinfoService(filePath);
});

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
