using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GeofenceCircle
{
    public int Id { get; set; }

    public short CircleIndex { get; set; }

    public string CircleName { get; set; } = null!;

    public string Equipment { get; set; } = null!;

    public bool OnOff { get; set; }

    public string Origin { get; set; } = null!;

    public double Radius { get; set; }

    public bool? Status { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public short? AlarmType { get; set; }

    public double? LatOrigin { get; set; }

    public double? LngOrigin { get; set; }

    public virtual Equipment EquipmentNavigation { get; set; } = null!;
}
