using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GeofenceRectangleNew
{
    public int Id { get; set; }

    public short RectangleIndex { get; set; }

    public string TopLeft { get; set; } = null!;

    public string DownRight { get; set; } = null!;

    public string Equipment { get; set; } = null!;

    public string RectangleName { get; set; } = null!;

    public int? ExternalId { get; set; }

    public int? NewId { get; set; }

    public virtual Gxequipment EquipmentNavigation { get; set; } = null!;
}
