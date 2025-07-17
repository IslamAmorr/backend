using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StandardPlace
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Icon { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string Name { get; set; } = null!;

    public double? X { get; set; }

    public double? Y { get; set; }

    public int? GovId { get; set; }

    public int? DelegId { get; set; }

    public virtual Place? Place { get; set; }
}
