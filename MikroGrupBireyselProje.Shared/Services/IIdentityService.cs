﻿namespace MikroGrupBireyselProje.Shared.Services;

public interface IIdentityService
{
    public Guid GetUserId { get; }

    public string GetFullName { get; }
}