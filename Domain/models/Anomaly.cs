using System;
using System.Collections.Generic;

namespace  Domain.models;

public partial class Anomaly
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public int AnomalyType { get; set; }

    public int? Customer { get; set; }

    public DateTime GeneratedDateGmt { get; set; }

    public DateTime ResolvedDateGmt { get; set; }

    public DateTime LastConnectionDateGmt { get; set; }

    public bool Resolved { get; set; }

    public bool? HaveIntervention { get; set; }
}
