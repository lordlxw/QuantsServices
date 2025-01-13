using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradehistoryId2
{
    public string Tscode { get; set; } = null!;

    public DateTime Tradedate { get; set; }

    public string Tradetime { get; set; } = null!;

    public decimal Tradeprice { get; set; }

    public string Dealtype { get; set; } = null!;

    public int? Brokerid { get; set; }

    public bool? Forwardcontact { get; set; }

    public string? Tradeid { get; set; }

    public string? Duration { get; set; }

    public string? Changebp { get; set; }

    public decimal? Netprice { get; set; }

    public long Id { get; set; }

    public DateTime? Addedtime { get; set; }

    public bool? Withdraw { get; set; }

    public string? SettleSpeed { get; set; }

    public DateOnly? DeliveryDate { get; set; }
}
