using MassTransit;
using MikroGrupBireyselProje.Shared.Options;

namespace MikroGrupBireyselProje.Order.API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddMasstransitExt(this IServiceCollection services,
        IConfiguration configuration)
    {
        var busOptions = configuration.GetSection(nameof(BusOption)).Get<BusOption>();


        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(busOptions!.RabbitMq.Address, hostConfigure =>
                {
                    hostConfigure.Username(busOptions.RabbitMq.UserName);
                    hostConfigure.Password(busOptions.RabbitMq.Password);
                });
            });
        });


        return services;
    }
}