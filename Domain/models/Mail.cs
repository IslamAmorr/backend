using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Mail
{
    public int Id { get; set; }

    public int Customer { get; set; }

    public string MailAdress { get; set; } = null!;

    public string? Name { get; set; }

    public int? ExternalId { get; set; }

    public int? ExternalId2 { get; set; }

    public virtual ICollection<SmsmailConfig> SmsmailConfigs { get; set; } = new List<SmsmailConfig>();
}
