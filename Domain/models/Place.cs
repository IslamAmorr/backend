using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Place
{
    public int Id { get; set; }

    public int Account { get; set; }

    public int ExternalId { get; set; }

    public short? TypeAccess { get; set; }

    public int? Type { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual Account AccountNavigation { get; set; } = null!;

    public virtual StandardPlace IdNavigation { get; set; } = null!;
}
