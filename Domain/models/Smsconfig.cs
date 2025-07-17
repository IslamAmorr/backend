using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Smsconfig
{
    public int Id { get; set; }

    public int? TelNumber { get; set; }
}
