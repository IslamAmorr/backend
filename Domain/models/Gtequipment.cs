using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gtequipment
{
    public string SerialNumber { get; set; } = null!;

    public short? TrackingPeriod { get; set; }

    public short? TrackingDistance { get; set; }

    public short? TrackingAngle { get; set; }

    public short? OverSpeedDetectionThreshold { get; set; }

    public short? AccelerationThreshold { get; set; }

    public string? CallNumber { get; set; }

    public short? MaxFuelVoltageLevel { get; set; }

    public short? MinFuelVoltageLevel { get; set; }

    public short? SendPeriod { get; set; }

    public bool? BuzzerFunction { get; set; }

    public double? TheoreticalFuelConsumption { get; set; }

    public short? FuelLevelPourcentageForStolenAlarm { get; set; }

    public short? Rpmthreshold { get; set; }

    public short? EngineTemperatureThreshold { get; set; }

    public short? Port { get; set; }

    public short? FuelLevelPercent4FillingAlarm { get; set; }
}
