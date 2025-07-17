using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StatisticHour
{
    public int Id { get; set; }

    public int TrackingTarget { get; set; }

    public DateTime StartDate { get; set; }

    public double Distance { get; set; }

    public short FuelConsom { get; set; }

    public short OverSpeedNbr { get; set; }

    public short MaxSpeed { get; set; }

    public short SpeedAvg { get; set; }

    public string Equipment { get; set; } = null!;

    public DateTime EndDate { get; set; }

    public virtual Car TrackingTargetNavigation { get; set; } = null!;
}
