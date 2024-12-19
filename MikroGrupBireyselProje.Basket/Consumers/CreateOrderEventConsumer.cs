using MassTransit;
using Microsoft.Extensions.Caching.Distributed;
using MikroGrupBireyselProje.Basket.Features.Basket;
using MikroGrupBireyselProje.Bus;

namespace MikroGrupBireyselProje.Basket.Consumers;

public class CreateOrderEventConsumer(IDistributedCache distributedCache)
    : IConsumer<OrderCreatedEvent>
{
    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        var cacheKey = string.Format(BasketConst.BasketCacheKey, context.Message.UserId);

        var hasBasket = await distributedCache.GetStringAsync(cacheKey);

        if (hasBasket is not null) await distributedCache.RemoveAsync(cacheKey);
    }
}