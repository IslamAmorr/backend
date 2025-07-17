using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class CardCouponLog
{
    public int Id { get; set; }

    public int? CardCoupon { get; set; }

    public double? QuantityL { get; set; }

    public double? PricePerL { get; set; }

    public double? TotalPrice { get; set; }

    public DateTime? ForMissionStartDateGmt { get; set; }

    public DateTime? ForMissionEndDateGmt { get; set; }

    public int? Driver { get; set; }

    public int? Car { get; set; }

    public short? Status { get; set; }

    public string? Description { get; set; }

    public int? Customer { get; set; }

    public int? Tank { get; set; }
}
