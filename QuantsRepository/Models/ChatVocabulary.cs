using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChatVocabulary
{
    public string Id { get; set; } = null!;

    /// <summary>
    /// 系统指令（1:下单， 2：改价， 3：撤单, 4: 其他）
    /// </summary>
    public short? Command { get; set; }

    /// <summary>
    /// 意图（1：成功，2：失败， 3：其他）
    /// </summary>
    public short? Intent { get; set; }

    /// <summary>
    /// 词库
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 中介ID
    /// </summary>
    public short? BrokerId { get; set; }

    /// <summary>
    /// 逻辑删除字段
    /// </summary>
    public bool? Deleted { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 回答权重
    /// </summary>
    public short? Weight { get; set; }
}
