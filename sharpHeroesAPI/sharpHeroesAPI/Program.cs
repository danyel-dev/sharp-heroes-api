using Microsoft.EntityFrameworkCore;
using sharpHeroesAPI.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectString = builder.Configuration.GetConnectionString("HeroConnString");

builder.Services.AddDbContext<HeroContext>(options =>
    options.UseMySql
    (
        connectString,
        ServerVersion.AutoDetect(connectString)
    )
);

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
