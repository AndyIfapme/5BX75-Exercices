﻿namespace Database.Domain.Common;

public class Entity
{
    public Guid Id { get; init; } = Guid.NewGuid();
}