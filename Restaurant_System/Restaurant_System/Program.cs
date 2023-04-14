using Microsoft.EntityFrameworkCore;
using Services.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
string connectionString = "User Id=postgres;Password=yasuomonodedo;Server=db.oeilqxqiyuauqqyajmzt.supabase.co;Port=5432;Database=postgres";
builder.Services.AddDbContext<RestaurantContext>(
    (options) => { options.UseNpgsql(connectionString);}
    );

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