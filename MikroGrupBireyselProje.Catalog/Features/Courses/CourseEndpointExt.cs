using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Catalog.Features.Courses.Create;
using MikroGrupBireyselProje.Catalog.Features.Courses.Delete;
using MikroGrupBireyselProje.Catalog.Features.Courses.GetAll.MikroGrupBireyselProje.Catalog.Features.Courses.GetAll;
using MikroGrupBireyselProje.Catalog.Features.Courses.GetAllByUserId;
using MikroGrupBireyselProje.Catalog.Features.Courses.GetById;
using MikroGrupBireyselProje.Catalog.Features.Courses.Update;

namespace MikroGrupBireyselProje.Catalog.Features.Courses;

public static class CourseEndpointsExt
{
    public static void AddCourseEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/courses")
            .MapAllCoursesQueryEndpoint()
            .MapAllCourseByUserIdEndpoint()
            .MapCourseByIdQueryEndpoint()
            .MapCreateCourseCommandEndpoint()
            .MapUpdateCourseCommandEndpoint()
            .MapDeleteCourseCommandEndpoint()
            .WithTags("Courses").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}