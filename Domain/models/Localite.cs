using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Localite
{
    public int? Id { get; set; }

    public double? LatLoc { get; set; }

    public double? LonLoc { get; set; }

    public string? NomLoc { get; set; }
}
