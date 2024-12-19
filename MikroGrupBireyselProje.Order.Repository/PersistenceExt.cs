using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MikroGrupBireyselProje.Order.Application.Contracts.Persistence;
using MikroGrupBireyselProje.Order.Persistence.Repositories;
using MikroGrupBireyselProje.Order.Repository;

namespace MikroGrupBireyselProje.Order.Persistence;

public static class PersistenceExt
{
    public static IServiceCollection AddPersistenceExt(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

        services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}