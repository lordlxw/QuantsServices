using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Cbd10yPricediff
{
    public int PricediffId { get; set; }

    public DateOnly Tradedate { get; set; }

    public decimal? Openprice { get; set; }

    public decimal? Closeprice { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public int? Volume { get; set; }

    public decimal? Change { get; set; }

    public decimal? Meandealprice { get; set; }

    public decimal? Duration { get; set; }

    public int? Totalvolume { get; set; }

    public long Id { get; set; }
}
