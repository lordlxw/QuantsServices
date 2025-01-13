using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserPreferConfig
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Json保存窗口大小以及券码信息
    /// </summary>
    public string? PreferWindowInfo { get; set; }

    /// <summary>
    /// 首次创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 最近更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 用户Id
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// Json保存聊天中介信息
    /// </summary>
    public string? PreferBrokerInfo { get; set; }
}
