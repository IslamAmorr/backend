using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StatisticsFuelConsumption
{
    public int Id { get; set; }

    public DateTime? StatisticsDateGmt { get; set; }

    public double? FuelConsumption { get; set; }

    public double? MinFuelLevel { get; set; }

    public DateTime? MinFuelLevelDateGmt { get; set; }

    public double? MaxFuelLevel { get; set; }

    public DateTime? MaxFuelLevelDateGmt { get; set; }

    public double? MinTemperature { get; set; }

    public DateTime? MinTemperatureDateGmt { get; set; }

    public double? MaxTemperature { get; set; }

    public DateTime? MaxTemperatureDateGmt { get; set; }

    public string Equipment { get; set; } = null!;

    public double? Refueling { get; set; }
}
