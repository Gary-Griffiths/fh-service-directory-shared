﻿namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.ServiceType;

public class ServiceTypeDto : IServiceTypeDto
{
    private ServiceTypeDto() { }
    public ServiceTypeDto(string id, string name, string? description)
    {
        Id = id; //use number 1 -> 99 in a string
        Name = name;
        Description = description;
    }

    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; } = default!;
}