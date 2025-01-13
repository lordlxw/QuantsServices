using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CtdDaychartPricediff
{
    public string Name { get; set; } = null!;

    public decimal? Openprice { get; set; }

    public decimal? Higiprice { get; set; }

    public decimal? Lowprice { get; set; }

    public decimal? Closeprice { get; set; }

    public DateOnly? Tradedate { get; set; }

    public string? Tscode { get; set; }

    public string? Ctdname { get; set; }

    public int? Volume { get; set; }
}
