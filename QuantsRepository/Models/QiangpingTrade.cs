using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class QiangpingTrade
{
    public string Id { get; set; } = null!;

    public string? Tscode { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public long? UsertradeId { get; set; }

    public short? DeleteFlag { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? InitialTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? EndTime { get; set; }

    public long? UserId { get; set; }

    public string? Type { get; set; }

    public string? Direction { get; set; }

    public decimal? Price { get; set; }

    public int? Amount { get; set; }

    public string? DeliverySpeed { get; set; }

    public bool? IsManual { get; set; }

    public long? CreateBy { get; set; }
}
