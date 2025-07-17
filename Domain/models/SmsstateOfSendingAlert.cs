using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class SmsstateOfSendingAlert
{
    public int Id { get; set; }

    public int? Customer { get; set; }

    public int? TelNumber { get; set; }

    public string? Smscontent { get; set; }

    public DateTime? SendingTimeGmt { get; set; }

    public int? TelNumberType { get; set; }

    public int? State { get; set; }

    public string? TelNumberStr { get; set; }
}
