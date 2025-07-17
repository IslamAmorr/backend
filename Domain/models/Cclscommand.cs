using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Cclscommand
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public DateTime? PostingTime { get; set; }

    public string? Response { get; set; }

    public string? Description { get; set; }

    public int? State { get; set; }

    public string? Hcs { get; set; }

    public string? Wt { get; set; }
}
