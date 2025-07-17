using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Adress { get; set; }

    public short? CarCount { get; set; }

    public short? ClientCommServerCount { get; set; }

    public int? CustomerStatus { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public string? Email3 { get; set; }

    public string? Name { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Tel3 { get; set; }

    public string? TimeZone { get; set; }

    public string? Website { get; set; }

    public int? Reseller { get; set; }

    public int? CustomerType { get; set; }

    public int? AccountsCount { get; set; }

    public int? WinTraceCount { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? Fax { get; set; }

    public long? SupportStatus { get; set; }

    public bool? IsReseller { get; set; }

    public string? DownloadPassword { get; set; }

    public string? SiteName { get; set; }

    public DateTime? SubscriptionDate { get; set; }

    public int? Map { get; set; }

    public long? Config { get; set; }

    public string? MessageToShow { get; set; }

    public bool? CanAddCars { get; set; }

    public string? Url { get; set; }

    public short? TimeOutToSendCommandMn { get; set; }

    public short? ConditionalSpeedForcedArmKmh { get; set; }

    public short? AuthorizedSmscount { get; set; }

    public DateTime? LastConnectionDateGmt { get; set; }

    public string? LastConnectionInfo { get; set; }

    public DateTime? ExpirationDateForResellerGmt { get; set; }

    public short? Gmt { get; set; }

    public short? CultureInfo { get; set; }

    public short? AutoLockCtmByTnvInDay { get; set; }

    public short? AutoLockCtmByResInDay { get; set; }

    public short? AutoShowMsg4PaymentInvoiceByTnvInDay { get; set; }

    public short? AutoShowMsg4PaymentInvoiceByResInDay { get; set; }

    public int? NbrEq { get; set; }

    public int? NbrEqDisconnectedMoreThanXtime { get; set; }

    public int? NbrEqConnectedFromXtime { get; set; }

    public int? FirstReseller { get; set; }

    public string? UserInsert { get; set; }

    public string? MachineInsert { get; set; }

    public string? UserUpdate { get; set; }

    public string? MachineUpdate { get; set; }

    public DateTime? DateInsert { get; set; }

    public DateTime? DateUpdate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
