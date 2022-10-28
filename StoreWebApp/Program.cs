using Microsoft.EntityFrameworkCore;
using StoreWepApp.Model.DBContext;
using StoreWepApp.repository;
using StoreWepApp.repository.Interface;
using StoreWepApp.repository.repository;
using StoreWepApp.Services.Context;
using StoreWepApp.Services.Contexts;
using StoreWepApp.Services.DI;
using StoreWepApp.Services.Interface.BasicData;
using StoreWepApp.Services.Services.BasicData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/// start
/// connect database   by repository pattern

/// </summary>

builder.Services.AddDbContext<StoreDBConext>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("Default"),
                       b => b.MigrationsAssembly(typeof(StoreDBConext).Assembly.FullName)));


//builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<IProductRepository,ProductRepository>();
//builder.Services.AddTransient(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddTransient(typeof(IProductService), typeof(ProductService));
builder.Services.AddTransient(typeof(IBasicDataContext), typeof(BasicDataContext));
//builder.Services.AddHostedService<>();


// end 


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
