using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Discount.Features.Discount.CreateDiscount;
using MikroGrupBireyselProje.Discount.Features.Discount.GetDiscountByCode;

namespace MikroGrupBireyselProje.Discount.Features.Discount;

public static class CourseEndpointsExt
{
    public static void AddDiscountEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/discounts")
            .MapCreateDiscountEndpoint()
            .MapDiscountByCodeEndpoint()
            .WithTags("discounts").WithApiVersionSet(apiVersionSet);
    }
}