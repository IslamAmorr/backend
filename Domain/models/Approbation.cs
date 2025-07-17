using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Approbation
{
    public int Id { get; set; }

    public string? Reference { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? Deadline { get; set; }

    public short? Type { get; set; }

    public int? Caller { get; set; }

    public int? ApprovingAcc { get; set; }

    public int? ApprovingDep { get; set; }

    public int? BenefIdAcc { get; set; }

    public int? BenefIdDep { get; set; }

    public int? BenefIdTt { get; set; }

    public string? Object { get; set; }

    public string? Context { get; set; }

    public double? MaxCost { get; set; }

    public int? Offer { get; set; }

    public short? State { get; set; }
}
