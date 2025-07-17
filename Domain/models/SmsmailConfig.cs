using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class SmsmailConfig
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public int AlertType { get; set; }

    public bool? SendOrNot { get; set; }

    public int? SendingPeriod { get; set; }

    public int? ExternalId { get; set; }

    public bool? Send { get; set; }

    public int? TankId { get; set; }

    public virtual ICollection<Mail> Mail { get; set; } = new List<Mail>();

    public virtual ICollection<TelNumber> TelNumbers { get; set; } = new List<TelNumber>();
}
