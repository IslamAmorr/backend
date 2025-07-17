using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Point
{
    public int Id { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int GeometricShape { get; set; }

    public short GeometricShapeOrder { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual GeometricShape GeometricShapeNavigation { get; set; } = null!;
}
