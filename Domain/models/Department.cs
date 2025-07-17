using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Department
{
    public int Id { get; set; }

    public int Customer { get; set; }

    public string Name { get; set; } = null!;

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual Customer CustomerNavigation { get; set; } = null!;

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    public virtual ICollection<TrackingTarget> TrackingTargets { get; set; } = new List<TrackingTarget>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
