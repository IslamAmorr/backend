using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class RepairMaintenanceLog
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public int? MaintenanceType { get; set; }

    public DateTime? DateCompletionGmt { get; set; }

    public double? MileageCompletion { get; set; }

    public double? Cost { get; set; }

    public string? InvoiceReference { get; set; }

    public string? Supplier { get; set; }

    public string? Description { get; set; }

    public int? AccidentDetails { get; set; }

    public int? Customer { get; set; }

    public double? PaidCost { get; set; }

    public DateTime? PaidDateGmt { get; set; }

    public int? MaintenanceReminder { get; set; }

    public double? EngineHoursCompletion { get; set; }
}
