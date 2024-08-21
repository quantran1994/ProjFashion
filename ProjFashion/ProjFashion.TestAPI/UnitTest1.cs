using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjFashion.Core.Interfaces.Repositories;
using ProjFashion.Infrastructure.DataAccess;
using ProjFashion.Infrastructure.DataAccess.Repositories;
using ProjectFashion.Application;
using ProjectFashion.Application.Features.Products.Commands.CreateProduct;
using ProjectFashion.Core.Interfaces;

namespace ProjFashion.TestAPI
{
    public class UnitTest1
    {
        private IProductRepository _productRepository;
        private IServiceScopeFactory _scopeFactory = null!;

        public UnitTest1()
        {
        }
        [Fact]
        public async Task Test1()
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
            var _mediator = serviceProvider.GetService<IMediator>();
            var _result = await _mediator.Send(new CreateProductCommand("a", "sdasda", 1, 1, Core.Enums.EGenderFashion.Unisex, false,"QuanTran"));
            Assert.True(_result);

        }
    }
}