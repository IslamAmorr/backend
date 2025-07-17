using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TimeZone
{
    public string Period { get; set; } = null!;

    public string Name { get; set; } = null!;
}
