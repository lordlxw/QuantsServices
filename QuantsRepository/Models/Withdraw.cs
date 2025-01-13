using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Withdraw
{
    public string Tscode { get; set; } = null!;

    public DateTime Actiontime { get; set; }

    public string Tradeid { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTime Tradedate { get; set; }

    public decimal Price { get; set; }

    public int Brokerid { get; set; }

    public string Dealtype { get; set; } = null!;
}
