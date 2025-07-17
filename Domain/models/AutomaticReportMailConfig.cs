using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AutomaticReportMailConfig
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public int ReportType { get; set; }

    public int Customer { get; set; }

    public bool Send { get; set; }

    public int? Mail { get; set; }
}
