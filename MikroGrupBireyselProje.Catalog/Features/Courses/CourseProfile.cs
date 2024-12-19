using AutoMapper;

namespace MikroGrupBireyselProje.Catalog.Features.Courses;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<Course, CourseDto>().ReverseMap();

        CreateMap<Feature, FeatureDto>().ReverseMap();
    }
}