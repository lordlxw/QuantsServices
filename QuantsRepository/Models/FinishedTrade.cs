using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class FinishedTrade
{
    public long Id { get; set; }

    public long? RealTradeId { get; set; }

    public string? Tscode { get; set; }

    public string? FinishCode { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public int? DeleteFlag { get; set; }

    public int? IsApproved { get; set; }

    public DateTime? UpdateTime { get; set; }

    public long? UpdateBy { get; set; }

    public int? HuibaoFlag { get; set; }

    public int? IsKp { get; set; }

    public int? IsHedge { get; set; }
}
