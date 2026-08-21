using _13_Aug_2026.Data;
using _13_Aug_2026.Repositary;
using _13_Aug_2026.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ======================================
// Database Connection
// ======================================

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));


// ======================================
// Dependency Injection
// ======================================

// Product
builder.Services.AddScoped<IProductService, ProductService>();

// Customer
builder.Services.AddScoped<ICustomerService, CustomerService>();


// ======================================
// JWT Authentication
// ======================================

builder.Services.AddAuthentication(
    JwtBearerDefaults.AuthenticationScheme
)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],

        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(
                builder.Configuration["Jwt:Key"]!
            )
        )
    };
});


// ======================================
// Authorization
// ======================================

builder.Services.AddAuthorization();


// ======================================
// Controllers
// ======================================

builder.Services.AddControllers();


// ======================================
// Swagger + JWT
// ======================================

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    // JWT Bearer definition
    options.AddSecurityDefinition(
        "Bearer",
        new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description =
                "Enter JWT token like: Bearer {your_token}"
        });

    // Apply JWT security
    options.AddSecurityRequirement(document =>
        new OpenApiSecurityRequirement
        {
            [
                new OpenApiSecuritySchemeReference(
                    "Bearer",
                    document)
            ] = []
        });
});


// ======================================
// Build Application
// ======================================

var app = builder.Build();


// ======================================
// HTTP Request Pipeline
// ======================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// ======================================
// Authentication & Authorization
// ======================================

app.UseAuthentication();

app.UseAuthorization();


// ======================================
// Controllers
// ======================================

app.MapControllers();

app.Run();