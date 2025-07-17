using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Grequipment
{
    public string SerialNumber { get; set; } = null!;

    public bool AdcAboveOrBelow { get; set; }

    public short AdcInputDelay { get; set; }

    public double AdcInputTriggerLevel { get; set; }

    public short? TrackingPeriod { get; set; }

    public short? OverSpeedDetectionThreshold { get; set; }

    public virtual ICollection<GeofenceArea> GeofenceAreas { get; set; } = new List<GeofenceArea>();

    public virtual Equipment SerialNumberNavigation { get; set; } = null!;
}
