using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class SmsmailChange
{
    public int Id { get; set; }

    public int? Customer { get; set; }

    public int? SmsmailConfig { get; set; }

    public bool? Status { get; set; }

    public int? ChangeType { get; set; }

    public DateTime? PostingTime { get; set; }
}
