using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Files.Features.File.Delete;
using MikroGrupBireyselProje.Files.Features.File.Upload;

namespace MikroGrupBireyselProje.Files.Features.File;

public static class CourseEndpointsExt
{
    public static void AddFileEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/files")
            .MapUploadFileEndpoint()
            .MapDeleteFileEndpoint()
            .WithTags("files").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}