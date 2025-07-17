using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StatisticAnomaly
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? TotalDetectedClientDisconnected { get; set; }

    public int? TotalInterventionClientDisconnected { get; set; }

    public int? TotalResolvedClientDisconnected { get; set; }

    public int? TotalDetectedEquipmentDisconnected { get; set; }

    public int? TotalInterventionEquipmentDisconnected { get; set; }

    public int? TotalResolvedEquipmentDisconnected { get; set; }
}
