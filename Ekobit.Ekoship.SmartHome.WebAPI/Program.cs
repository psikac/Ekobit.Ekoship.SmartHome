using Ekobit.Ekoship.SmartHome.Data;
using Ekobit.Ekoship.SmartHome.Services;
using Ekobit.Ekoship.SmartHome.Services.Contracts;
using Ekobit.Ekoship.SmartHome.Services.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Inject Entity Framework database context
builder.Services.AddDbContext<SmartHomeContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inject repositories
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IHomeRepository, HomeRepository>();

// Inject services
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IHomeService, HomeService>();

// Inject automapper
builder.Services.AddAutoMapper(typeof(Program));

// Inject controllers and API infrastructure
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
