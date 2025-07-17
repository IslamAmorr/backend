using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GeofenceRectangle
{
    public int Id { get; set; }

    public string DownLeft { get; set; } = null!;

    public string Equipment { get; set; } = null!;

    public bool OnOff { get; set; }

    public short RectangleIndex { get; set; }

    public string RectangleName { get; set; } = null!;

    public string UpRight { get; set; } = null!;

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual Gpequipment EquipmentNavigation { get; set; } = null!;
}
