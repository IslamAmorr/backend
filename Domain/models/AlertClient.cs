using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AlertClient
{
    public string? MachineName { get; set; }

    public int? Customer { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public int? LastAlertId { get; set; }
}
