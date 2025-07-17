using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GeometricShape
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Account { get; set; }

    public int? ExternalId { get; set; }

    public int? ArgbLineColor { get; set; }

    public short? LineWidth { get; set; }

    public int? ExternalId2 { get; set; }

    public short? Changed { get; set; }

    public virtual ICollection<Point> Points { get; set; } = new List<Point>();

    public virtual Polygon? Polygon { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();

    public virtual Way? Way { get; set; }
}
