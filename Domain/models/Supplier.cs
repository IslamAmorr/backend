using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Supplier
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? SaveDate { get; set; }

    public short? Type { get; set; }
}
