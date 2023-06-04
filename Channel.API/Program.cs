using Channel.Domain.Context;
using Channel.Repository.Implementation;
using Channel.Repository.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IChannelRepository, ChannelRepository>();
//var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? builder.Configuration.GetConnectionString("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? builder.Configuration.GetConnectionString("DB_NAME");
var dbUserId = Environment.GetEnvironmentVariable("DB_USERID") ?? builder.Configuration.GetConnectionString("DB_USERID");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? builder.Configuration.GetConnectionString("DB_PASSWORD");
var connectionString = $"Data Source=.\\sqlexpress;initial catalog=vtalk-user;user id=anhvy;password=abc#191199;Encrypt=False";
Console.WriteLine(connectionString);
builder.Services.AddDbContext<ChannelContext>(options => options.UseSqlServer(connectionString));
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
