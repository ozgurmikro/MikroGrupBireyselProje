using System.Text.Json;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using MikroGrupBireyselProje.Basket.Dto;
using MikroGrupBireyselProje.Shared;
using MikroGrupBireyselProje.Shared.Services;

namespace MikroGrupBireyselProje.Basket.Features.Basket.RemoveDiscountCoupon;

public record RemoveDiscountCouponCommand : IRequestByServiceResult;

public class RemoveDiscountCouponCommandHandler(
    IIdentityService identityService,
    IDistributedCache distributedCache) : IRequestHandler<RemoveDiscountCouponCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(RemoveDiscountCouponCommand request,
        CancellationToken cancellationToken)
    {
        var cacheKey = string.Format(BasketConst.BasketCacheKey, identityService.GetUserId);
        var hasBasket = await distributedCache.GetStringAsync(cacheKey, cancellationToken);


        if (string.IsNullOrEmpty(hasBasket))
            return ServiceResult.ErrorAsNotFound();

        var basket = JsonSerializer.Deserialize<BasketDto>(hasBasket);

        basket!.RemoveDiscount();


        await distributedCache.SetStringAsync(cacheKey, JsonSerializer.Serialize(basket), cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}