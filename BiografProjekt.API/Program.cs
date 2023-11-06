using BiografProjekt.Repo.Repositories;
using BiografProjekt.Repo.DTO;
using BiografProjekt.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMovie, MovieRepo>();

builder.Services.AddDbContext<BiografProjekt.Repo.Dbcontext.DatabaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

var app = builder.Build();

// CORS Policy - so 2 processes can talk to eah other:
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

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
