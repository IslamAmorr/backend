using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CardCoupon
{
    public int Id { get; set; }

    public string? CardCouponRef { get; set; }

    public DateTime? DateGmt { get; set; }

    public double? QuantityL { get; set; }

    public bool? IsCard { get; set; }

    public int? RecurringLoadConfig { get; set; }

    public int? SupplierFuel { get; set; }

    public int? Driver { get; set; }

    public int? Car { get; set; }

    public double? PricePerL { get; set; }

    public double? TotalPrice { get; set; }

    public bool? EnableAlert { get; set; }

    public int? Customer { get; set; }

    public bool? IsCardCouponWorkByMoney { get; set; }

    public int? Department { get; set; }

    public int? Tank { get; set; }
}
