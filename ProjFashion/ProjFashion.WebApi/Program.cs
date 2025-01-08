using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using ProjFashion.Infrastructure.DataAccess;
using ProjFashion.WebApi.Authorizes;
using ProjFashion.WebApi.GroupEndPoints;
using ProjFashion.WebApi.Middlewares;
using ProjFashion.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme);
builder.Services.AddAuthorization();
builder.Services.Configure<AuthorizationOptions>(options =>
{
    options.AddPolicy("AtLeast21",
            policy => policy.Requirements.Add(new MinimumAgeRequirement(21)));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<TestffffMiddleware>();
builder.Services.AddSingleton<IAuthorizationHandler,MinimumAgeHandler>();
builder.Services.AddTransient<CategoryService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
builder.Services.AddDbContext<ApplicationDbContext>(cfg =>
{
    cfg.UseSqlServer("Server=localhost;Database=test;User Id=sa;Password=sa;Trusted_Connection=True; TrustServerCertificate=True;");
});


app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.MapGroupCategoryRoutes();

//app.Run(async context => context.Response.Headers.Add("a","Test value"));
app.UseMiddleware<TestffffMiddleware>();
//app.UseMiddleware<LogURLMiddleware>();
app.Run();
