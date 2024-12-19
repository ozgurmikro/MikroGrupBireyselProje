using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Basket.Features.Basket.AddBasket;
using MikroGrupBireyselProje.Basket.Features.Basket.ApplyDiscountRate;
using MikroGrupBireyselProje.Basket.Features.Basket.DeleteBasket;
using MikroGrupBireyselProje.Basket.Features.Basket.GetBasket;
using MikroGrupBireyselProje.Basket.Features.Basket.RemoveDiscountCoupon;

namespace MikroGrupBireyselProje.Basket.Features.Basket;

public static class BasketEndpointsExt
{
    public static void AddBasketEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/baskets")
            .MapGetAllBasketByUserIdEndpoint()
            .MapAddBasketEndpoint()
            .MapDeleteBasketEndpoint()
            .MapApplyDiscountRateCommandEndpoint()
            .MapARemoveDiscountCouponCommandEndpoint()
            .WithTags("baskets").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}