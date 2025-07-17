using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Offer
{
    public int Id { get; set; }

    public string? Reference { get; set; }

    public string? Object { get; set; }

    public DateTime? SaveDate { get; set; }

    public string? Details { get; set; }

    public double? Cost { get; set; }

    public int? Supplier { get; set; }

    public int? Approbation { get; set; }

    public bool? Accepted { get; set; }

    public string? ApprobationReference { get; set; }
}
