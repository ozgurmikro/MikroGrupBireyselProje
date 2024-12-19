using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Catalog.Features.Categories.Create;
using MikroGrupBireyselProje.Catalog.Features.Categories.GetAll;
using MikroGrupBireyselProje.Catalog.Features.Categories.GetById;

namespace MikroGrupBireyselProje.Catalog.Features.Categories;

public static class CategoryEndpointsExt
{
    public static void AddCategoryEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/categories")
            .MapCreateCategoryEndpoint()
            .MapCategoryByIdQueryEndpoint()
            .MapCategoryByIdQueryEndpointV2()
            .MapAllCategoryQueryEndpoint()
            .WithTags("Categories").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}