using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class QueryType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
