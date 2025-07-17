using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Intervention
{
    public int Id { get; set; }

    public int? Anomaly { get; set; }

    public string? Panne { get; set; }

    public string? PanneDescr { get; set; }

    public string? FixedBy { get; set; }

    public DateTime? DateIntervetion { get; set; }
}
