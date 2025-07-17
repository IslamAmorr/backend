using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class GpsdataByDrvCd
{
    public long Id { get; set; }

    public DateTime AcquisitionTime { get; set; }

    public short Direction { get; set; }

    public string? Equipment { get; set; }

    public string? OriginalEquipment { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int RecordType { get; set; }

    public short Speed { get; set; }

    public long Status { get; set; }

    public short? FuelLevel { get; set; }

    public double? Temperature { get; set; }

    public double? Mileage { get; set; }

    public bool? OnMove { get; set; }

    public double? Acceleration { get; set; }

    public double? TotalFuel { get; set; }

    public int? AccelerationPosition { get; set; }

    public int? Rpm { get; set; }

    public double? EngineHours { get; set; }

    public int? AxleWeight { get; set; }

    public int? AxleIndex { get; set; }

    public string? TachographData { get; set; }

    public int? EngineTemperature { get; set; }

    public bool? IgnOn { get; set; }

    public short? Gpslevel { get; set; }

    public short? Gsmlevel { get; set; }

    public long? OtherInfo { get; set; }

    public int? Customer { get; set; }

    public string? Message { get; set; }

    public string DriverCode { get; set; } = null!;

    public long? TripLot { get; set; }
}
