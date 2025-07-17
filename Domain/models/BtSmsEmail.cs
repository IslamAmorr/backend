using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class BtSmsEmail
{
    public int Id { get; set; }

    public string? TypeMessage { get; set; }

    public string? Destinataire { get; set; }

    public int? TypeAlerte { get; set; }

    public string? TextAlerte { get; set; }

    public string? EtatEnvoie { get; set; }

    public string? DateInsertion { get; set; }

    public string? HeurInsertion { get; set; }

    public string? DateEnvoi { get; set; }

    public string? HeurEnvoi { get; set; }
}
