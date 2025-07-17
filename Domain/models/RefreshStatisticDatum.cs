using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class RefreshStatisticDatum
{
    public string Equipment { get; set; } = null!;

    public DateTime? BeginStatisticDate { get; set; }

    public DateTime? AcquisitionTime { get; set; }

    public int? TotalSendBytes { get; set; }
}
