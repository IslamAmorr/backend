using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AccountPage
{
    public int Account { get; set; }

    public int PageId { get; set; }

    public bool AccessRight { get; set; }

    public virtual Account AccountNavigation { get; set; } = null!;
}
