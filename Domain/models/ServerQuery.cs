using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class ServerQuery
{
    public int Id { get; set; }

    public string Equipment { get; set; } = null!;

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? Param4 { get; set; }

    public string? Param5 { get; set; }

    public string? Param6 { get; set; }

    public DateTime PostingTime { get; set; }

    public int QueryState { get; set; }

    public int QueryType { get; set; }

    public string? ResponseMessage { get; set; }

    public string SenderId { get; set; } = null!;

    public int? TimeOut { get; set; }

    public int ExternalId { get; set; }

    public string? Hcsname { get; set; }

    public string? Description { get; set; }

    public int? Account { get; set; }

    public int? TrackingTarget { get; set; }

    public int? TelTonikaProfile { get; set; }

    public short? Csport { get; set; }
}
