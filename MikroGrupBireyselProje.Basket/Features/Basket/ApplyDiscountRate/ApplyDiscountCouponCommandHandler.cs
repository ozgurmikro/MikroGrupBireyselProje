﻿using System.Text.Json;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using MikroGrupBireyselProje.Basket.Dto;
using MikroGrupBireyselProje.Shared;
using MikroGrupBireyselProje.Shared.Services;

namespace MikroGrupBireyselProje.Basket.Features.Basket.ApplyDiscountRate;

public class ApplyDiscountCouponCommandHandler(IIdentityService identityService, IDistributedCache distributedCache)
    : IRequestHandler<ApplyDiscountCouponCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(ApplyDiscountCouponCommand request, CancellationToken cancellationToken)
    {
        var cacheKey = string.Format(BasketConst.BasketCacheKey, identityService.GetUserId);
        var hasBasket = await distributedCache.GetStringAsync(cacheKey, cancellationToken);


        if (string.IsNullOrEmpty(hasBasket))
            return ServiceResult.ErrorAsNotFound();

        var basket = JsonSerializer.Deserialize<BasketDto>(hasBasket);


        basket.ApplyNewDiscount(request.Coupon, request.Rate);

        await distributedCache.SetStringAsync(cacheKey, JsonSerializer.Serialize(basket), cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}