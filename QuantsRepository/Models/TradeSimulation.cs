using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulation
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Tscode { get; set; } = null!;

    public DateTime Orderdate { get; set; }

    public decimal Price { get; set; }

    public int Volume { get; set; }

    public DateTime? Tradedate { get; set; }

    public string? Result { get; set; }

    public string Dealtype { get; set; } = null!;

    public int? Status { get; set; }

    public string? OpponentId { get; set; }

    public decimal? Profit { get; set; }

    public int? Onholdvolume { get; set; }

    public decimal? Netprice { get; set; }

    public decimal? Pvbp { get; set; }

    public decimal? Brokerage { get; set; }

    public short? Ordertype { get; set; }

    public Guid? Guid { get; set; }

    public decimal? PvpbRate { get; set; }

    public int? BalanceOrder { get; set; }

    public int? ConditionalOrderId { get; set; }

    public short? ConditionalOrderType { get; set; }

    public decimal? StopLoss { get; set; }

    public decimal? StopProfit { get; set; }

    public TimeOnly? Updatedate { get; set; }

    public virtual SysUser User { get; set; } = null!;
}
