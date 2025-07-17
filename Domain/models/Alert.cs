using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Alert
{
    public int Id { get; set; }

    public DateTime AcquisitionTime { get; set; }

    public int AlertType { get; set; }

    public string? Equipment { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string? RunTrace { get; set; }

    public short Speed { get; set; }

    public double? X { get; set; }

    public int? Y { get; set; }

    public int? GeometricShape { get; set; }

    public string? Message { get; set; }

    public int? Customer { get; set; }

    public short? AccelerationPosition { get; set; }

    public short? Rpm { get; set; }

    public short? AxleWeight { get; set; }

    public short? AxleIndex { get; set; }

    public short? EngineTemperature { get; set; }

    public bool? IgnOn { get; set; }

    public short? Gpslevel { get; set; }

    public short? Gsmlevel { get; set; }

    public short? FuelLevel { get; set; }

    public bool? OnMove { get; set; }

    public short? Temperature { get; set; }

    public short? Direction { get; set; }

    public double? Mileage { get; set; }

    public long? OtherInfo { get; set; }

    public bool? EquipmentIsTrackingTarget { get; set; }

    public int? TrackingTarget { get; set; }

    public int? Driver { get; set; }

    public double? EngineHours { get; set; }

    public double? TotalFuel { get; set; }

    public double? Level1 { get; set; }

    public double? Pressure1 { get; set; }

    public double? Level2 { get; set; }

    public double? Pressure2 { get; set; }

    public double? Level3 { get; set; }

    public double? Pressure3 { get; set; }

    public double? Level4 { get; set; }

    public double? Pressure4 { get; set; }

    public double? Level5 { get; set; }

    public double? Pressure5 { get; set; }

    public double? Level6 { get; set; }

    public double? Pressure6 { get; set; }

    public double? PressureC1a { get; set; }

    public double? PressureC2a { get; set; }

    public double? PressureC1v { get; set; }

    public double? PressureC2v { get; set; }

    public double? HourCounterPompA { get; set; }

    public double? HourCounterPompB { get; set; }

    public double? HourCounterPompC { get; set; }

    public double? HourCounterPompD { get; set; }

    public double? HourCounterPompE { get; set; }

    public double? HourCounterPompF { get; set; }

    public double? TempPompA { get; set; }

    public double? TempPompB { get; set; }

    public double? TempPompC { get; set; }

    public double? TempPompD { get; set; }

    public double? TempPompE { get; set; }

    public double? TempPompF { get; set; }

    public double? TempLocal { get; set; }

    public double? Intensity { get; set; }

    public double? Tension { get; set; }

    public double? Voie1 { get; set; }

    public double? Voie2 { get; set; }

    public double? Voie3 { get; set; }

    public double? Voie4 { get; set; }

    public double? Voie5 { get; set; }

    public double? Voie6 { get; set; }

    public double? Voie7 { get; set; }
}
