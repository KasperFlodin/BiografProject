var builder = WebApplication.CreateBuilder(args);

// part 1 of CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
        .WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMovie, MovieRepo>();
builder.Services.AddScoped<IGenre, GenreRepo>();
builder.Services.AddScoped<IHall, HallRepo>();
builder.Services.AddScoped<ISeat, SeatRepo>();
builder.Services.AddScoped<ITicket, TicketRepo>();
builder.Services.AddScoped<ITheater, TheaterRepo>();
builder.Services.AddScoped<IUser, UserRepo>();

builder.Services.AddDbContext<BiografProjekt.Repo.Dbcontext.DatabaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

var app = builder.Build();

//// CORS Policy - so 2 processes can talk to eah other:
//app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

// Part 2 of CORS
app.UseCors("CorsPolicy");

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
