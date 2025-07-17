using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Delegation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public double? TheLeft { get; set; }

    public double? TheTop { get; set; }

    public double? TheRight { get; set; }

    public double? TheButtom { get; set; }

    public int? GovId { get; set; }
}
