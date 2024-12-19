using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Files.Features.File.Delete;

public record DeleteFileCommand(string FileName) : IRequestByServiceResult;