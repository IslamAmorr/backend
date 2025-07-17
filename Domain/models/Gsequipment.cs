using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gsequipment
{
    public string SerialNumber { get; set; } = null!;

    public string? MobileName { get; set; }

    public string? Sim1number { get; set; }

    public string? Sim2number { get; set; }

    public int? TrackingPeriodInS { get; set; }
}
