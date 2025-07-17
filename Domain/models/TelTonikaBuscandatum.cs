using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TelTonikaBuscandatum
{
    public int Id { get; set; }

    public int? VehiculeSpeed { get; set; }

    public int? AccelerationPedal { get; set; }

    public int? FuelComsuption { get; set; }

    public int? FuelLevel { get; set; }

    public int? EngineRpm { get; set; }

    public int? VehiculeWeight { get; set; }

    public int? EngineHours { get; set; }

    public int? TotalDistance { get; set; }

    public int? EngineTemperature { get; set; }
}
