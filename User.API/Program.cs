using Microsoft.EntityFrameworkCore;
using User.Domain.Context;
using User.Mapper;
using User.Repository.Implementation;
using User.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? builder.Configuration.GetConnectionString("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? builder.Configuration.GetConnectionString("DB_NAME");
var dbUserId = Environment.GetEnvironmentVariable("DB_USERID") ?? builder.Configuration.GetConnectionString("DB_USERID");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? builder.Configuration.GetConnectionString("DB_PASSWORD");
var connectionString = $"Data Source={dbHost};initial catalog={dbName};user id={dbUserId};password={dbPassword};Encrypt=False";
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString, x => x.MigrationsAssembly("User.API")));

builder.Services.AddAutoMapper(typeof(UserProfile));

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
