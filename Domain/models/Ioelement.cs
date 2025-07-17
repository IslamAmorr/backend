using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Ioelement
{
    public int Id { get; set; }

    public int? IoelementProp { get; set; }

    public int? Value { get; set; }

    public string? Description { get; set; }

    public string? Equipment { get; set; }

    public DateTime? AcquisitionTime { get; set; }
}
