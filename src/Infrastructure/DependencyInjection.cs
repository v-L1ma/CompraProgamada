using CompraProgamada.Application.Repositories;
using CompraProgamada.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CompraProgamada.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}