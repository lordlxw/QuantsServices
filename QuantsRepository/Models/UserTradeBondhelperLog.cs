using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserTradeBondhelperLog
{
    /// <summary>
    ///  
    /// </summary>
    public int Userid { get; set; }

    public DateTime CreateTime { get; set; }

    public string Action { get; set; } = null!;

    public int TargetOrderId { get; set; }

    public string? LoginIp { get; set; }
}
