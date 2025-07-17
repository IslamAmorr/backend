using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StopRun
{
    public int Id { get; set; }

    public int TrackingTarget { get; set; }

    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Status { get; set; } = null!;

    public int Period { get; set; }

    public double Distance { get; set; }

    public string Equipment { get; set; } = null!;

    public virtual Car TrackingTargetNavigation { get; set; } = null!;
}
