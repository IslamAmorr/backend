using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TempRefresh
{
    public string Equipment { get; set; } = null!;

    public DateTime AcquisitionTime { get; set; }

    public int? AdcVoltage { get; set; }

    public short Direction { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public short Speed { get; set; }

    public long Status { get; set; }

    public short Temperature { get; set; }

    public short? FuelLevel { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public bool? Connected { get; set; }

    public int RecordType { get; set; }

    public bool? Sent { get; set; }

    public double? Mileage { get; set; }

    public bool? OnMove { get; set; }

    public double? TempMileage { get; set; }
}
