using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Trip
{
    public int Id { get; set; }

    public int TrackingTarget { get; set; }

    public double DestinationLatitude { get; set; }

    public double DestinationLongitude { get; set; }

    public string DestinationName { get; set; } = null!;

    public int Distance { get; set; }

    public int? Driver { get; set; }

    public string Equipment { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime PrimaryEndDateTime { get; set; }

    public DateTime PrimaryStartDateTime { get; set; }

    public DateTime RealEndDateTime { get; set; }

    public DateTime RealStartDateTime { get; set; }

    public double SourceLatitude { get; set; }

    public double SourceLongitude { get; set; }

    public string SourceName { get; set; } = null!;

    public int? GeometricShape { get; set; }

    public int? ExternalId { get; set; }

    public string Status { get; set; } = null!;

    public int? WayDistanceThreshold { get; set; }

    public string? Mission { get; set; }

    public int? Line { get; set; }

    public int? ExternalId2 { get; set; }

    public short? GpStopTrackingPeriod { get; set; }

    public short? GpFixedMovingDistance { get; set; }

    public short? GrOfflineTrackingPeriod { get; set; }

    public short? OverspeedThreshold { get; set; }

    public short? TrackingPeriod { get; set; }

    public virtual Driver? DriverNavigation { get; set; }

    public virtual Equipment EquipmentNavigation { get; set; } = null!;

    public virtual GeometricShape? GeometricShapeNavigation { get; set; }

    public virtual TrackingTarget TrackingTargetNavigation { get; set; } = null!;
}
