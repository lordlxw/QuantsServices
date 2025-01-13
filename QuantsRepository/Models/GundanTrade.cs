using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class GundanTrade
{
    public long Id { get; set; }

    public string? Tscode { get; set; }

    public long? UserTradeId { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public string? GundanSourceNum { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? IsFinished { get; set; }

    public string? Direction { get; set; }

    public DateTime? GundanDate { get; set; }

    public string? GundanRoleNum { get; set; }

    public int? Sort { get; set; }
}
