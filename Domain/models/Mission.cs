using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Mission
{
    public int Id { get; set; }

    public string? DriverCode { get; set; }

    public byte? MissionDef { get; set; }

    public string? Equipment { get; set; }

    public DateTime? AcquisitionTime { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public virtual Equipment? EquipmentNavigation { get; set; }
}
