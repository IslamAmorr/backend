using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TrackingTarget
{
    public int Id { get; set; }

    public int Department { get; set; }

    public string? Icon { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public string? TrajectoryHexColor { get; set; }

    public string? VisitingCustomerParam { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Department DepartmentNavigation { get; set; } = null!;

    public virtual PersonneGp? PersonneGp { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
