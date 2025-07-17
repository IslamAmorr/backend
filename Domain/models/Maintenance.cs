using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Maintenance
{
    public int Id { get; set; }

    public int MaintenanceType { get; set; }

    public int Car { get; set; }

    public int? MileageIndex { get; set; }

    public DateTime? MaintenanceDate { get; set; }

    public int? MaintenanceFrequence { get; set; }

    public bool? IsReminderByOdometer { get; set; }

    public DateTime? LastDueDateGmt { get; set; }

    public int? RecurringDateConfig { get; set; }

    public short? Changed { get; set; }

    public bool? EnableGenerateAlertByWt { get; set; }

    public DateTime? LastConfirmedAlertByWtgmt { get; set; }

    public DateTime? LastGenerateAlertByExternAppGmt { get; set; }

    public double? WarnMeBeforeNdayKm { get; set; }

    public bool? EnableGenerateAlertByExternApp { get; set; }

    public int? Customer { get; set; }

    public DateTime? ExpiryDateGmtforWt { get; set; }

    public DateTime? ExpiryDateGmtforExernApp { get; set; }

    public DateTime? BeginStartRecurringDateGmt { get; set; }

    public double? NextWarnedDueMileageForWt { get; set; }

    public double? NextWarnedDueMileageForExternApp { get; set; }

    public short? IsReminderBy { get; set; }
}
