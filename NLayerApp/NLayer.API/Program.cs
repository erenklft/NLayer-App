using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using NLayer.Core.Repsitories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository;
using NLayer.Repository.UnityOfWorks;
using NLayer.Service.Mapping;
using NLayer.Service.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*builder.Services.AddScoped<UnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(IGenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));



 builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});
*/





// Configure the HTTP request pipeline.
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
