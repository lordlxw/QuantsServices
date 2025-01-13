using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradekchartOut
{
    public string? Tradedate { get; set; }

    public string? Tscode { get; set; }

    public string? Bondname { get; set; }

    public string? Source { get; set; }

    public int? Volume { get; set; }

    public decimal? Volumeamount { get; set; }

    public decimal? Volumemoney { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public decimal? Meandealprice { get; set; }

    public decimal? Openprice { get; set; }

    public decimal? Closeprice { get; set; }

    public decimal? Initrate { get; set; }

    public int Id { get; set; }

    public string? Valid { get; set; }

    public decimal? FpOp { get; set; }

    public decimal? FpCp { get; set; }

    public decimal? FpHp { get; set; }

    public decimal? FpLp { get; set; }

    public decimal? FpMp { get; set; }
}
