using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Account
{
    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Id { get; set; }

    public int? ExternalId { get; set; }

    public bool ViewAllTrackingObjects { get; set; }

    public int Customer { get; set; }

    public string? Role { get; set; }

    public string? DepName { get; set; }

    public int? ExternalId2 { get; set; }

    public long? OptionsConfig { get; set; }

    public long? UitrackingPageConfig1 { get; set; }

    public long? UitrackingPageConfig2 { get; set; }

    public long? UitrackingPageConfig3 { get; set; }

    public DateTime? LastConnectionDateGmt { get; set; }

    public string? LastConnectionInfo { get; set; }

    public long? ShowedAlarmInRtcfg { get; set; }

    public string? TrackPageConfigStr { get; set; }

    public int? ResellerJok { get; set; }

    public short? MapZoomToFocusObjLevel { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public short MinPeriodToDetectStpInS { get; set; }

    public double MinStopPeriodInS { get; set; }

    public int? AdminAcc { get; set; }

    public string? PasswordClr { get; set; }

    public string? PasswordCrpt { get; set; }

    public bool IsAdmin { get; set; }

    public virtual ICollection<AccountEquipment> AccountEquipments { get; set; } = new List<AccountEquipment>();

    public virtual ICollection<AccountPage> AccountPages { get; set; } = new List<AccountPage>();

    public virtual Customer CustomerNavigation { get; set; } = null!;

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
