using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CustomerLicence
{
    public int Id { get; set; }

    public int? SubResellerName { get; set; }

    public int? SubscriptionFormula { get; set; }

    public int? Scenario { get; set; }

    public DateTime? WarrantyDate { get; set; }

    public int? WarrantyPeriod { get; set; }

    public DateTime? TimeRenewSubscription { get; set; }

    public DateTime? DateContractWt { get; set; }

    public DateTime? DateContractWorkForce { get; set; }

    public int? NumberEquipement { get; set; }

    public DateTime? DateExpireWt { get; set; }

    public DateTime? DateExpireWorkForce { get; set; }

    public int? SendAlert { get; set; }
}
