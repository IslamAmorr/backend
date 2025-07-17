using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class PreviousPassword
{
    public string PasswordHash { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTimeOffset CreateDate { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
