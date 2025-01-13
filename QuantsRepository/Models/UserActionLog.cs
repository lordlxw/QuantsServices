using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserActionLog
{
    /// <summary>
    /// 关联userid
    /// </summary>
    public int Userid { get; set; }

    /// <summary>
    /// 事件类型
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 时间
    /// </summary>
    public DateTime? Time { get; set; }
}
