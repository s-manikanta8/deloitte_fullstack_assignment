using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using WebApplication5.Models;
using WebApplication5.Repositories;
using WebApplication5.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = "myUsers",
        ValidIssuer = "mySystem",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is jwt token required secret key used to generate jwt token required for authentiation"))
    };
});

builder.Services.AddControllers();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddDbContext<SalesDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesDbContext")));
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
