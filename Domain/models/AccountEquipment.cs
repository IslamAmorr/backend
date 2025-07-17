using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AccountEquipment
{
    public int Account { get; set; }

    public string Equipment { get; set; } = null!;

    public bool AccessRight { get; set; }

    public virtual Account AccountNavigation { get; set; } = null!;
}
