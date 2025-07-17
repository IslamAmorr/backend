using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class EquipmentLicence
{
    public string SerialNumber { get; set; } = null!;

    public string? SerialBoxEquipment { get; set; }

    public int? SerialPuce { get; set; }

    public DateTime? DateEquipmentAllocation { get; set; }

    public DateTime? DateUpService { get; set; }

    public DateTime? DateContract { get; set; }

    public string? NumInvoice { get; set; }

    public DateTime? DateInvoice { get; set; }

    public string? NumDeliveryOrder { get; set; }

    public DateTime? DateDeliveryOrder { get; set; }
}
