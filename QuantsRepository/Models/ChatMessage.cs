using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChatMessage
{
    /// <summary>
    /// 主键（每条消息）
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 聊天人ID
    /// </summary>
    public int? ChatId { get; set; }

    /// <summary>
    /// 消息保存（目前只支持文本）
    /// </summary>
    public string? ChatMessage1 { get; set; }

    /// <summary>
    /// 中介ID
    /// </summary>
    public short? BrokerId { get; set; }

    /// <summary>
    /// 方向
    /// </summary>
    public short? Direction { get; set; }

    /// <summary>
    /// 消息即时时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 关联的一笔交易ID
    /// </summary>
    public long? TradeId { get; set; }

    /// <summary>
    /// 聊天内容是否和交易相关
    /// </summary>
    public bool? IsTrade { get; set; }

    /// <summary>
    /// 该条消息插入的时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 引用消息
    /// </summary>
    public string? QuoteMessage { get; set; }

    public string? ChannelId { get; set; }

    public short? QuoteDirection { get; set; }

    public string? OrderId { get; set; }
}
