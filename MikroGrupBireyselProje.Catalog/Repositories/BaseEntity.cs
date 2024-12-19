﻿using MongoDB.Bson.Serialization.Attributes;

namespace MikroGrupBireyselProje.Catalog.Repositories;

public abstract class BaseEntity
{
    [BsonElement("_id")] public Guid Id { get; set; }
}