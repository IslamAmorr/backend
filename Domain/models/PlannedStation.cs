using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class PlannedStation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? RecurrenceInfo { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? DepartureDate { get; set; }

    public int? Order { get; set; }

    public int? Place { get; set; }

    public int? Line { get; set; }
}
