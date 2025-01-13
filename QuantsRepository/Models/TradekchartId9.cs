using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradekchartId9
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

    public decimal? FpOp { get; set; }

    public decimal? FpCp { get; set; }

    public decimal? FpHp { get; set; }

    public decimal? FpLp { get; set; }

    public decimal? NpOp { get; set; }

    public decimal? NpCp { get; set; }

    public decimal? NpHp { get; set; }

    public decimal? NpLp { get; set; }

    public long Id { get; set; }
}
