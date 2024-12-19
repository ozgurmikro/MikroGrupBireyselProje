using MikroGrupBireyselProje.Catalog.Features.Courses;
using MikroGrupBireyselProje.Catalog.Repositories;

namespace MikroGrupBireyselProje.Catalog.Features.Categories;

public class Category : BaseEntity
{
    public string Name { get; set; } = default!;
    public List<Course>? Courses { get; set; }
}