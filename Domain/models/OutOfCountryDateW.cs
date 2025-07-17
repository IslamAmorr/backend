using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class OutOfCountryDateW
{
    public string Equipment { get; set; } = null!;

    public DateTime? DateOfLastOutOfCountry { get; set; }
}
