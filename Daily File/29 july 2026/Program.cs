using _29_july_2026.Controllers.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
    builder.Services.AddScoped<IEmployeeServise, EmployeeServise>();
builder.Services.AddScoped<IVehicleService, VehicleService>();

// Learn more about configuring O
//
// penAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
