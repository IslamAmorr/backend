using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Requête
{
    public int Id { get; set; }

    public DateTime AcquisitionTime { get; set; }

    public int? AdcVoltage { get; set; }

    public short Direction { get; set; }

    public int Distance { get; set; }

    public string Equipment { get; set; } = null!;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int RecordType { get; set; }

    public short Speed { get; set; }

    public long Status { get; set; }

    public short? FuelLevel { get; set; }

    public short Temperature { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public double? Mileage { get; set; }

    public int? AnalogInput1 { get; set; }

    public int? AnalogInput2 { get; set; }

    public int? AnalogInput3 { get; set; }

    public int? AnalogInput4 { get; set; }

    public double? Acceleration { get; set; }

    public bool? OnMove { get; set; }
}
