using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TestWithoutError
{
    public int Id { get; set; }

    public int Customer { get; set; }

    public string Equipment { get; set; } = null!;

    public int TestedProblem { get; set; }

    public DateTime SavedDate { get; set; }

    public int? QueryTypeAll { get; set; }
}
