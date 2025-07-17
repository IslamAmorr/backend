using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CarDocumentLog
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public short? DocumentType { get; set; }

    public DateTime? DateAvailableFromGmt { get; set; }

    public DateTime? DateAvailableToGmt { get; set; }

    public DateTime? PaidDateGmt { get; set; }

    public double? Cost { get; set; }

    public double? PaidCost { get; set; }

    public int? Customer { get; set; }

    public int? CarDocumentReminder { get; set; }

    public string? InvoiceReference { get; set; }

    public string? Supplier { get; set; }

    public string? Description { get; set; }
}
