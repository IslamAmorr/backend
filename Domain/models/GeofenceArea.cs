using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GeofenceArea
{
    public int Id { get; set; }

    public string AreaName { get; set; } = null!;

    public double DownLatitude { get; set; }

    public string Equipment { get; set; } = null!;

    public double LeftLongitude { get; set; }

    public short Mode { get; set; }

    public double RightLongitude { get; set; }

    public double UpLatitude { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual Grequipment EquipmentNavigation { get; set; } = null!;
}
