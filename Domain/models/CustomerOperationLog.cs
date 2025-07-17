using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CustomerOperationLog
{
    public int Id { get; set; }

    public DateTime? OperationDateGmt { get; set; }

    public int? Account { get; set; }

    public int? Customer { get; set; }

    public int? OperationType { get; set; }

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public string OtherInfo { get; set; } = null!;

    public string LoginAccount { get; set; } = null!;

    public string CustomerName { get; set; } = null!;
}
