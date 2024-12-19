﻿using System.ComponentModel.DataAnnotations;

namespace MikroGrupBireyselProje.Discount.Repositories;

public class MongoOption
{
    [Required] public required string DatabaseName { get; init; } = default!;
    [Required] public required string ConnectionString { get; init; } = default!;
}