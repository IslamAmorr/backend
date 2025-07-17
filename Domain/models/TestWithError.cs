using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class TestWithError
{
    public int Id { get; set; }

    public int Customer { get; set; }

    public string Equipment { get; set; } = null!;

    public int? TestedProblem { get; set; }

    public string? ShowType { get; set; }

    public string? InvalidData { get; set; }

    public string? CorrectedValue { get; set; }

    public string? StandardValue { get; set; }

    public string? DataEquipment { get; set; }

    public string? DataInBase { get; set; }

    public DateTime? SavedDate { get; set; }

    public bool SendedMail { get; set; }

    public bool Corrected { get; set; }

    public int? QueryTypeAll { get; set; }

    public bool? Accepted { get; set; }
}
