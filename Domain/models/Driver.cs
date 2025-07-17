using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Driver
{
    public int Id { get; set; }

    public int Department { get; set; }

    public string? Email { get; set; }

    public string FirstName { get; set; } = null!;

    public string? FixTelphoneNumber { get; set; }

    public string LastName { get; set; } = null!;

    public string? MobileTelephoneNumber { get; set; }

    public int ExternalId { get; set; }

    public string? DriverCode { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual Department DepartmentNavigation { get; set; } = null!;

    public virtual ICollection<DriverEquipmentCode> DriverEquipmentCodes { get; set; } = new List<DriverEquipmentCode>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
