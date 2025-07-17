using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Message
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public string? MessageText { get; set; }

    public string? ReceivedOrSent { get; set; }

    public DateTime? SentTime { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public int? Speed { get; set; }

    public string? Status { get; set; }

    public virtual Equipment EquipmentNavigation { get; set; } = null!;
}
