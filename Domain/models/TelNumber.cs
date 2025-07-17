using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TelNumber
{
    public int Id { get; set; }

    public int? Customer { get; set; }

    public string Tel { get; set; } = null!;

    public string? Name { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public short? Type { get; set; }

    public virtual ICollection<SmsmailConfig> SmsmailConfigs { get; set; } = new List<SmsmailConfig>();
}
