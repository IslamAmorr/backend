using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Way
{
    public int Id { get; set; }

    public virtual GeometricShape IdNavigation { get; set; } = null!;
}
