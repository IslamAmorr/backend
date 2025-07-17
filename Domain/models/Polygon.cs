using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Polygon
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int? ArgbAreaColor { get; set; }

    public short? AreaWidth { get; set; }

    public int? Governorate { get; set; }

    public int? Delegation { get; set; }

    public virtual GeometricShape IdNavigation { get; set; } = null!;
}
