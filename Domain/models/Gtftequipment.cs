using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gtftequipment
{
    public string SerialNumber { get; set; } = null!;

    public double? BaseMileageKm { get; set; }
}
