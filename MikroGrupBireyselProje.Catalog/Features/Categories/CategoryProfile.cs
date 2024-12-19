using AutoMapper;
using MikroGrupBireyselProje.Catalog.Features.Categories.Create;

namespace MikroGrupBireyselProje.Catalog.Features.Categories;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        // CreateCategoryCommand -> Category
        CreateMap<CreateCategoryCommand, Category>();

        CreateMap<CategoryDto, Category>().ReverseMap();
    }
}