﻿using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;

public interface IOpenReferralOrganisationWithServicesDto
{
    string? Description { get; set; }
    string Id { get; set; }
    string? Logo { get; set; }
    string? Name { get; set; }
    ICollection<OpenReferralServiceDto>? Services { get; set; }
    string? Uri { get; set; }
    string? Url { get; set; }
}