using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Catalog.Features.Categories.Create;

public record CreateCategoryCommand(string Name) : IRequestByServiceResult<CreateCategoryResponse>;