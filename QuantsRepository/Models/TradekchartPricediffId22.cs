using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradekchartPricediffId22
{
    public string Tscode { get; set; } = null!;

    public DateOnly Tradedate { get; set; }

    public decimal? Openprice { get; set; }

    public decimal? Closeprice { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public int? Volume { get; set; }

    public decimal? Change { get; set; }

    public decimal? Meandealprice { get; set; }

    public decimal? Duration { get; set; }

    public string Name { get; set; } = null!;

    public int? Totalvolume { get; set; }

    public long Id { get; set; }
}
