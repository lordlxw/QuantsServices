using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulationUser
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public decimal? MaxProfit { get; set; }

    public decimal? MaxLoss { get; set; }

    public bool Activated { get; set; }

    public int? AllowedMaxOpen { get; set; }

    public int? AllowedMaxLoss { get; set; }

    public int? DailyCloseLoss { get; set; }

    public short? UserStatus { get; set; }

    public DateTime? DisableStartDate { get; set; }

    public decimal? DailyDrawDown { get; set; }

    public DateOnly? DrawDownDate { get; set; }

    public short? UserPrivilege { get; set; }

    public virtual SysUser User { get; set; } = null!;
}
