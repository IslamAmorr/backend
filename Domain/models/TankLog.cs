using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TankLog
{
    public int Id { get; set; }

    public int? Tank { get; set; }

    public DateTime? OperationDateGmt { get; set; }

    public short? OperationType { get; set; }

    public double? OperationCapacityInL { get; set; }

    public int? CardCoupon { get; set; }
}
