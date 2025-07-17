using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class MissionDef
{
    public string? Description { get; set; }

    public int Customer { get; set; }

    public byte MissionCode { get; set; }
}
