using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Line
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Way { get; set; }
}
