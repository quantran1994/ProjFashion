using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjFashion.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(cfg =>
{
    cfg.UseSqlServer("Server=localhost;Database=test;User Id=sa;Password=sa;Trusted_Connection=True; TrustServerCertificate=True;");
});
var app = builder.Build();
