using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChatWorkOrder
{
    /// <summary>
    /// 主键
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 状态 0 已发起， 1已接受， 2 已处理 ， 3 挂起
    /// </summary>
    public short Status { get; set; }

    /// <summary>
    /// 消息ID
    /// </summary>
    public string? MessageId { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remarks { get; set; }

    /// <summary>
    /// 发起人
    /// </summary>
    public int? CreateBy { get; set; }

    /// <summary>
    /// 审核人
    /// </summary>
    public int? ReviewedBy { get; set; }

    /// <summary>
    /// 类型 系统 1， 用户 2
    /// </summary>
    public short? Type { get; set; }

    /// <summary>
    /// 逗号分割 询价单ID
    /// </summary>
    public string? TradeIds { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    public short? Weight { get; set; }

    public short? BrokerId { get; set; }

    public string? ChannelId { get; set; }
}
