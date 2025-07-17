using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CustomerInput
{
    public int Customer { get; set; }

    public int Input { get; set; }

    public int InputOption { get; set; }

    public int? ExternalId { get; set; }
}
