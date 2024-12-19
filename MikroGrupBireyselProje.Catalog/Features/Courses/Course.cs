using MikroGrupBireyselProje.Catalog.Features.Categories;
using MikroGrupBireyselProje.Catalog.Repositories;

namespace MikroGrupBireyselProje.Catalog.Features.Courses;

public class Course : BaseEntity
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;


    public decimal Price { get; set; }

    public Guid UserId { get; set; } = default!;

    public string? Picture { get; set; }


    public DateTime CreatedTime { get; set; }

    public Feature? Feature { get; set; }

    public Guid CategoryId { get; set; } = default!;

    public Category? Category { get; set; }
}