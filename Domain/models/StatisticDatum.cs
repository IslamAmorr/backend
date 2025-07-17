using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class StatisticDatum
{
    public int Id { get; set; }

    public string? Equipment { get; set; }

    public DateTime? AcquisitionTime { get; set; }

    public int? TotalSendBytes { get; set; }
}
