using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CardCouponReminder
{
    public int Id { get; set; }

    public int? CardCoupon { get; set; }

    public int? Driver { get; set; }

    public int? RecurringLoadConfig { get; set; }

    public bool? EnableGenerateAlertByExternApp { get; set; }

    public bool? EnableGenerateAlertByWt { get; set; }

    public DateTime? LastConfirmedAlertByWtgmt { get; set; }

    public DateTime? LastGenerateAlertByExternAppGmt { get; set; }

    public short? Changed { get; set; }

    public DateTime? CreatedReminderDate { get; set; }

    public double? RecurringQuantityInL { get; set; }

    public double? WarnMeBeforNday { get; set; }

    public DateTime? ExpiredDateGmt { get; set; }

    public int? Customer { get; set; }

    public DateTime? BeginStartRecurringDateGmt { get; set; }

    public DateTime? ExpiryDateGmtforExernApp { get; set; }
}
