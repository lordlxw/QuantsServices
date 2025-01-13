using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ReviewMessage
{
    public string? ReviewMessageinfo { get; set; }

    public long? UsertradeId { get; set; }

    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 0(未审核）1（已确认处理）
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// 审核人
    /// </summary>
    public string? Reviewer { get; set; }

    public int Id { get; set; }

    public int? UserId { get; set; }

    public long? UserTradeBondhelperId { get; set; }

    public virtual UserTradeBondhelper? Usertrade { get; set; }
}
