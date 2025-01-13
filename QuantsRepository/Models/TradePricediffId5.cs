using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradePricediffId5
{
    public string Tscode1 { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Tradedate { get; set; }

    public decimal Tradeprice { get; set; }

    public bool? Forwardcontact { get; set; }

    public DateTime? Addedtime { get; set; }

    public string? Tdxcode { get; set; }

    public string? Brokername { get; set; }

    public bool? Withdraw { get; set; }

    public string? Tradeid { get; set; }
}
