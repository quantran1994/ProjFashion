using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectFashion.Core.Interfaces;
using ProjFashion.Core.Interfaces.Repositories;
using ProjFashion.Infrastructure.DataAccess;
using ProjFashion.Infrastructure.DataAccess.Repositories;
using ProjectFashion.Application;
using ProjectFashion.Application.Features.Products.Commands.CreateProduct;
using ProjFashion.Core.Enums;
namespace Nunit.TestApplication
{
    public class Tests
    {
        private IMediator _mediator;
        [OneTimeSetUp]
        public void Setup()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ApplicationDbContext>(cfg =>
            {
                cfg.UseSqlServer("Server=localhost;Database=test;User Id=sa;Password=sa;Trusted_Connection=True; TrustServerCertificate=True;");
            });
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.InjectApplicationService();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            _mediator = serviceProvider.GetService<IMediator>()!;
        }

        [Test]
        public async Task Test1()
        {
            var _result = await _mediator.Send(new CreateProductCommand("a", "sdasda", 1, 1, EGenderFashion.Unisex, false, "QuanTran"));
            Assert.True(_result);
            Assert.Pass();
        }
    }
}