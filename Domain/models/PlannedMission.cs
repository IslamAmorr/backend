using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class PlannedMission
{
    public int Id { get; set; }

    public DateTime? BeginMissionEstimatedDateGmt { get; set; }

    public DateTime? BeginMissionRealDateGmt { get; set; }

    public DateTime? MaxEndMissionDateGmt { get; set; }

    public int? Account { get; set; }

    public int? Driver { get; set; }

    public int? StartPlaceOfMission { get; set; }

    public int? DestinationPlaceOfMission { get; set; }

    public bool? ShowNotification { get; set; }

    public short? Status { get; set; }

    public short? MissionType { get; set; }

    public int? TrackingTarget { get; set; }

    public string? Purpose { get; set; }

    public int? Customer { get; set; }

    public DateTime? StartingEstimatedDateGmt { get; set; }

    public DateTime? StartingRealDateGmt { get; set; }

    public int? RealMissionPeriodInS { get; set; }

    public string? NumberStr { get; set; }

    public double? OdometerOut { get; set; }

    public double? OdometerIn { get; set; }

    public double? WeightLoaded { get; set; }

    public double? PriceOfWeightLoaded { get; set; }

    public double? EstimatedTotalFuelConsumed { get; set; }

    public double? RealTotalFuelConsumed { get; set; }

    public double? Cost { get; set; }
}
