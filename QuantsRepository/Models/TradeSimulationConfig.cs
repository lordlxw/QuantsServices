using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulationConfig
{
    public int Id { get; set; }

    public short? UserPrivilege { get; set; }

    public short? Volume { get; set; }

    public short? AllowedTotalLoss { get; set; }

    public short? Threshold { get; set; }

    public short AllowedDailyLoss { get; set; }

    public short? AllowedTscodes { get; set; }

    public string? LevelName { get; set; }

    public string? GroupName { get; set; }

    public short? AllowedHolding { get; set; }

    public short? BalanceInMorning { get; set; }

    public short? GroupId { get; set; }

    public short? MutliTscodes { get; set; }

    public short? CloseInAfternoon { get; set; }

    public short? MaxDailyTrade { get; set; }
}
