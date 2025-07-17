using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AlertConfiguration
{
    public int AlertType { get; set; }

    public string Equipment { get; set; } = null!;

    public bool NotifiedBySms { get; set; }

    public bool Reported { get; set; }

    public string? Param { get; set; }
}
