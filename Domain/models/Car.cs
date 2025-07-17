using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Car
{
    public int Id { get; set; }

    public string? AdcUse { get; set; }

    public double? EmptyVoltage { get; set; }

    public short? FuelContainerCapacity { get; set; }

    public double? FullVoltage { get; set; }

    public string Matricule { get; set; } = null!;

    public double? FuelEstimation { get; set; }

    public string? CarType { get; set; }

    public int? Model { get; set; }

    public int? ModelYear { get; set; }

    public int? FuelType { get; set; }

    public int? DriverId { get; set; }

    public virtual TrackingTarget IdNavigation { get; set; } = null!;

    public virtual ICollection<StatisticHour> StatisticHours { get; set; } = new List<StatisticHour>();

    public virtual ICollection<StopRun> StopRuns { get; set; } = new List<StopRun>();
}
