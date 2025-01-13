using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserTrade
{
    public long UserTradeId { get; set; }

    public DateTime? TradeTime { get; set; }

    public string Direction { get; set; } = null!;

    public string Tscode { get; set; } = null!;

    public decimal Price { get; set; }

    public string Volume { get; set; } = null!;

    public DateTime DeliveryTime { get; set; }

    public long CreateBy { get; set; }

    public DateTime CreateTime { get; set; }

    public long? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }

    public string? DeliverySpeed { get; set; }

    public long UserId { get; set; }

    public int? Status { get; set; }

    public bool? Forward { get; set; }

    public string? TradeNum { get; set; }

    public long? ParentId { get; set; }

    public string? RestVolume { get; set; }

    public int? Version { get; set; }

    public string? RelativeNum { get; set; }

    public string? SourceNum { get; set; }

    public string? FinishVolume { get; set; }

    public decimal? WorstPrice { get; set; }

    public int? IsYouxian { get; set; }

    public int? YouxianLevel { get; set; }

    public string? OrderType { get; set; }

    public string? QiangpingId { get; set; }

    public short? BrokerId { get; set; }

    public string? ChannelId { get; set; }

    public bool? IsLock { get; set; }

    public int? ProxyId { get; set; }

    public bool? Kongtou { get; set; }

    public bool? Duotou { get; set; }

    public virtual ICollection<RealTrade> RealTrades { get; set; } = new List<RealTrade>();
}
