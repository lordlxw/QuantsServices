using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class RealTrade
{
    /// <summary>
    /// 实际交易单ID
    /// </summary>
    public long RealTradeId { get; set; }

    /// <summary>
    /// 下单交易ID
    /// </summary>
    public long UserTradeId { get; set; }

    /// <summary>
    /// 交易时间
    /// </summary>
    public DateTime? TradeTime { get; set; }

    /// <summary>
    /// 买还是卖
    /// </summary>
    public string? Direction { get; set; }

    /// <summary>
    /// 债券代码
    /// </summary>
    public string? Tscode { get; set; }

    /// <summary>
    /// 交易量
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// 价格
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// 创建者
    /// </summary>
    public long? CreateBy { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public long? UpdateBy { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    public int? Status { get; set; }

    /// <summary>
    /// 交易单单号
    /// </summary>
    public string? TradeNum { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public string? DeliverySpeed { get; set; }

    public string? CounterParty { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactType { get; set; }

    public int? JiaogeStatus { get; set; }

    public string? LockedBy { get; set; }

    public long? ParentId { get; set; }

    public string? MarketMaker { get; set; }

    public decimal? Fee { get; set; }

    public DateTime? JiaogeDeliveryTime { get; set; }

    public virtual UserTrade UserTrade { get; set; } = null!;
}
