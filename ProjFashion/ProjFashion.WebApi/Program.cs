using Microsoft.AspNetCore.Authorization;
using ProjFashion.WebApi.Authorizes;
using ProjFashion.WebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Configure<AuthorizationOptions>(options =>
{
    options.AddPolicy("AtLeast21",
            policy => policy.Requirements.Add(new MinimumAgeRequirement(21)));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<TestffffMiddleware>();
builder.Services.AddSingleton<IAuthorizationHandler,MinimumAgeHandler>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//builder.Services.AddDbContext<ApplicationDbContext>(cfg =>
//{
//    cfg.UseSqlServer("Server=localhost;Database=test;User Id=sa;Password=sa;Trusted_Connection=True; TrustServerCertificate=True;");
//});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//app.Run(async context => context.Response.Headers.Add("a","Test value"));
app.UseMiddleware<TestffffMiddleware>();
//app.UseMiddleware<LogURLMiddleware>();

app.Run();
