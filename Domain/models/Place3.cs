using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Place3
{
    public long Id { get; set; }

    public string PlaceName { get; set; } = null!;

    public string? SymbolPath { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? Description { get; set; }

    public string? Account { get; set; }
}
