using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Backend.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    "Server=localhost;Database=HorseRacingDB;User ID=root;Password=8484884848;Port=3306;";

builder.Services.AddDbContext<DbContextApp>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


builder.Services.AddControllers();

builder.Services.AddAutoMapper(cfg => { }, typeof(MappingProfile));
var app = builder.Build();

app.UseHttpsRedirection();

// Map controllers so routes work
app.MapControllers();

app.Run();