using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Ggequipment
{
    public string SerialNumber { get; set; } = null!;

    public string? AuhthorizedNumber3 { get; set; }

    public string? AuhthorizedNumber1 { get; set; }

    public string? AuhthorizedNumber2 { get; set; }

    public short? TrackingPeriodInS { get; set; }
}
