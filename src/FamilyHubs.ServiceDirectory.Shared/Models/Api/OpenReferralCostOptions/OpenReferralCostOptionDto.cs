﻿namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;

public class OpenReferralCostOptionDto : IOpenReferralCostOptionDto
{
    public OpenReferralCostOptionDto() { }
    public OpenReferralCostOptionDto(
        string id,
        string amount_description,
        decimal amount,
        string? linkId,
        string? option,
        DateTime? valid_from,
        DateTime? valid_to
    )
    {
        Id = id;
        Amount_description = amount_description;
        Amount = amount;
        LinkId = linkId;
        Option = option;
        Valid_from = valid_from;
        Valid_to = valid_to;
    }
    public string Id { get; set; } = default!;
    public string Amount_description { get; init; } = default!;
    public decimal Amount { get; init; }
    public string? LinkId { get; init; }
    public string? Option { get; init; }
    public DateTime? Valid_from { get; init; }
    public DateTime? Valid_to { get; init; }
}

