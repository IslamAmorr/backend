using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Map
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int ExternalId { get; set; }
}
