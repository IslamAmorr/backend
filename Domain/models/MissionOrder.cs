using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class MissionOrder
{
    public int Id { get; set; }

    public string? Reference { get; set; }

    public int? Driver { get; set; }

    public int? Car { get; set; }

    public string? MissionDescription { get; set; }

    public double? OdometerIn { get; set; }

    public double? OdometerOut { get; set; }

    public DateTime? StartMissionDateGmt { get; set; }

    public DateTime? EndMissionDateGmt { get; set; }

    public int? StandardPlaceStart { get; set; }

    public int? StandardPlaceEnd { get; set; }

    public DateTime? PlaceStartDateGmt { get; set; }

    public DateTime? PlaceEndDateGmt { get; set; }

    public short? Status { get; set; }

    public int? Customer { get; set; }

    public bool? EnableGenerateAlertByExternApp { get; set; }

    public bool? AlertGeneratedByExternApp { get; set; }

    public double? WeightLoaded { get; set; }

    public double? WeightPriceCharged { get; set; }

    public double? EstimatedTotalFuelConsumed { get; set; }

    public double? RealTotalFuelConsumed { get; set; }

    public bool? EnableGenerateAlertPayementExpiredByWt { get; set; }

    public bool? EnableGenerateAlertPayementExpiredByExternApp { get; set; }

    public string? NumberStr { get; set; }

    public bool? EnableGenerateAlertByWt { get; set; }
}
