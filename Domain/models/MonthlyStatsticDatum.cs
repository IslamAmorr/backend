using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class MonthlyStatsticDatum
{
    public int Month { get; set; }

    public int Year { get; set; }

    public string Equipment { get; set; } = null!;

    public int? TotalSendBytes { get; set; }

    public int? TotalReceivedBytesFromServer { get; set; }
}
