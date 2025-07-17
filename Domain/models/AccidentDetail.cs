using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class AccidentDetail
{
    public int Id { get; set; }

    public int? Car { get; set; }

    public int? Driver { get; set; }

    public DateTime? AccidentDateGmt { get; set; }

    public int? AccidentLocation { get; set; }

    public string? Details { get; set; }

    public short? Status { get; set; }

    public string? Dammage { get; set; }

    public string? AccidentReportRef { get; set; }

    public byte[]? AccidentReportImg { get; set; }

    public int? Customer { get; set; }

    public short? AccidentType { get; set; }

    public string? AccidentLocationFullName { get; set; }

    public DateTime? LastGeneratedAlertByExternAppGmt { get; set; }
}
