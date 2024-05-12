using AutoMapper;
using SalesTaxesBll.Interfaces;
using SalesTaxesBll.Logic;
using SalesTaxesBll.Mappings;
using SalesTaxesDal.Repositories.ItemsRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region DI
builder.Services.AddScoped<IGoods, Goods>();
builder.Services.AddScoped<IReceipt, Receipt>();
builder.Services.AddScoped<ISales, Sales>();

//Repositories
builder.Services.AddScoped<IItemsRepo, ItemsRepo>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ModelMapping));
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
