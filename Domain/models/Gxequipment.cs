using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gxequipment
{
    public string SerialNumber { get; set; } = null!;

    public bool? MileageActivated { get; set; }

    public short? MovingTrackingPeriod { get; set; }

    public short? StopTrackingPeriod { get; set; }

    public double? FixedMovingDistance { get; set; }

    public short? OverSpeedDetectionThreshold { get; set; }

    public string? ServerIp { get; set; }

    public short? Port { get; set; }

    public bool? Initialized { get; set; }

    public bool? SupportOverSpeed { get; set; }

    public virtual ICollection<GeofenceRectangleNew> GeofenceRectangleNews { get; set; } = new List<GeofenceRectangleNew>();
}
