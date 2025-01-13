using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Trade
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Tscode { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal NetPrice { get; set; }

    public int Volume { get; set; }

    public DateTime TradeTime { get; set; }

    public short TradeType { get; set; }

    public DateOnly SettlleDate { get; set; }
}
