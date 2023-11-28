using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SoBugger.WebApi.Data;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Filters;
using SoBugger.WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(setup =>
{
    setup.Filters.Add<GlobalExceptionFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<SoBuggerDbContext>(setup =>
{
    setup.UseSqlite("Data Source=SoBugger.db");
    setup.ReplaceService<IMigrationsSqlGenerator, CustomMigrationsSqlGenerator>();
});

var app = builder.Build();

AutoMapperExtensions.Configure(app);

using var scoped = app.Services.CreateScope();
using var db = scoped.ServiceProvider.GetRequiredService<SoBuggerDbContext>();
try
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}
catch (Exception ex)
{
    Console.WriteLine($"Generator database error : \r\n {ex.Message}");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();