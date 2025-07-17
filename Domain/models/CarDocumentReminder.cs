using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CarDocumentReminder
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public short? DocumentType { get; set; }

    public DateTime? LastDueDateGmt { get; set; }

    public double? ActivationCost { get; set; }

    public double? RecurringCost { get; set; }

    public short? ExpenditureType { get; set; }

    public int? RecurringDateConfig { get; set; }

    public short? Changed { get; set; }

    public double? WarnMeBeforeNday { get; set; }

    public bool? EnableGenerateAlertByWt { get; set; }

    public bool? EnableGenerateAlertByExternApp { get; set; }

    public DateTime? LastConfirmedAlertByWtgmt { get; set; }

    public DateTime? LastGenerateAlertByExternAppGmt { get; set; }

    public int? Customer { get; set; }

    public DateTime? ExpiryDateGmtforWt { get; set; }

    public DateTime? ExpiryDateGmtforExernApp { get; set; }

    public DateTime? BeginStartRecurringDateGmt { get; set; }
}
