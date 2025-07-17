using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class DriverEquipmentCode
{
    public string Equipment { get; set; } = null!;

    public byte CodeIndex { get; set; }

    public int? Driver { get; set; }

    public virtual Driver? DriverNavigation { get; set; }

    public virtual Equipment EquipmentNavigation { get; set; } = null!;
}
