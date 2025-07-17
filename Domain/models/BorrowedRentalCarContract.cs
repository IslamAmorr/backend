using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class BorrowedRentalCarContract
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public int? FirstDriver { get; set; }

    public int? SecondDriver { get; set; }

    public double? Cost { get; set; }

    public DateTime? ContractStartDateGmt { get; set; }

    public DateTime? ContractEndDateGmt { get; set; }

    public DateTime? CarOutDateGmt { get; set; }

    public DateTime? CarInDateGmt { get; set; }

    public string? ContractRef { get; set; }

    public double? OdometerInKm { get; set; }

    public double? OdometerOutKm { get; set; }

    public int? GazFuelLevelPercent { get; set; }

    public bool? EnableAlertEndRenewContractConfirmedByWt { get; set; }

    public DateTime? LastGeneratedAlertEndRenewConfirmedByWt { get; set; }

    public int? Customer { get; set; }

    public bool? EnableAlertForEndRenewContractByApp { get; set; }

    public DateTime? LastGenratedAlertEndRenewContractByApp { get; set; }

    public int? RecurringDateConfig { get; set; }

    public DateTime? EndRenewedDateGmt { get; set; }

    public double? ActivationCost { get; set; }

    public double? RecurringCost { get; set; }

    public short? ContractType { get; set; }

    public short? Changed { get; set; }

    public double? WarnMeBeforeNday { get; set; }

    public DateTime? ExpiryDatePaymentGmtforExernApp { get; set; }

    public DateTime? ExpiryDatePaymentGmtforWt { get; set; }

    public DateTime? BeginStartRecurringDateGmt { get; set; }

    public bool? EnableGenerateAlertPayementExpiredByExternApp { get; set; }

    public bool? EnableGenerateAlertPaymentExpiredByWt { get; set; }

    public DateTime? LastConfirmedAlertPayementByWtgmt { get; set; }
}
