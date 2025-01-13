using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysTradeLimitLevelConfig
{
    public int Id { get; set; }

    public int MaxSingleVolume { get; set; }

    public int? MaxVolume { get; set; }

    public decimal? MinProfitDaily { get; set; }

    public int? MaxKeepDay { get; set; }

    public decimal? MinProfitAlltime { get; set; }

    public int? MaxDeliveryDay { get; set; }

    public int? UpgradeAmountDaily { get; set; }

    public int? DowngradeAmountDaily { get; set; }

    public int? Level { get; set; }

    public int? DailyTradeAmount { get; set; }
}
