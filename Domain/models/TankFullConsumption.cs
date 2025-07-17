using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TankFullConsumption
{
    public string? Equipment { get; set; }

    public DateTime AcquisitionTime { get; set; }

    public double? ConsumptionPercent { get; set; }

    public double? Consumption { get; set; }

    public int Id { get; set; }

    public int? NumTank { get; set; }
}
