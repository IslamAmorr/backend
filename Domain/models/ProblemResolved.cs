using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class ProblemResolved
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public int TestedProblem { get; set; }

    public DateTime DateSave { get; set; }

    public string? Value { get; set; }
}
