using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Tradehistory
{
    public int UserId { get; set; }

    public DateTime Tradedate { get; set; }

    public string Tscode { get; set; } = null!;

    public string Bidtype { get; set; } = null!;

    public decimal Price { get; set; }

    public int Volume { get; set; }

    public string ClearSpeed { get; set; } = null!;

    public decimal? NetPrice { get; set; }
}
