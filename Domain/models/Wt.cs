using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Wt
{
    public string Id { get; set; } = null!;

    public int? Customer { get; set; }

    public string? Version { get; set; }

    public string? Hcsaddress { get; set; }

    public int? Hcsport { get; set; }

    public string? Dbserver { get; set; }

    public string? Dbname { get; set; }

    public string? Dblogin { get; set; }

    public string? Dbpassword { get; set; }

    public DateTime? FirstExecutionDate { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public int? LicensePeriod { get; set; }

    public string? MachineName { get; set; }
}
