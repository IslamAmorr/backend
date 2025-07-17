using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class BorrowedRentalCarInvoice
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public int? FirstDriver { get; set; }

    public int? SecondDriver { get; set; }

    public double? Cost { get; set; }

    public int? BorrowedRentalCarContract { get; set; }

    public short? ContratType { get; set; }

    public double? PaidCost { get; set; }

    public DateTime? DateInvoiceGmt { get; set; }

    public DateTime? InvoiceFromGmt { get; set; }

    public DateTime? InvoiceToGmt { get; set; }

    public double? OdometerInKm { get; set; }

    public double? OdometerOutKm { get; set; }

    public DateTime? PaidDateGmt { get; set; }

    public string? InvoiceRef { get; set; }
}
