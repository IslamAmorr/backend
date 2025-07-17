using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Changement2
{
    public int Id { get; set; }

    public int? IntId { get; set; }

    public int? CustomerId { get; set; }

    public string? OperationType { get; set; }

    public string? ObjectName { get; set; }

    public bool? Status { get; set; }

    public string? StringId { get; set; }

    public DateTime? PostingTime { get; set; }

    public string? Source { get; set; }
}
