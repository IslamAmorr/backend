using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class PersonneGp
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FixTelphoneNumber { get; set; }

    public string? MobileTelephoneNumber { get; set; }

    public virtual TrackingTarget IdNavigation { get; set; } = null!;
}
