using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Channel
{
    public string Id { get; set; } = null!;

    /// <summary>
    /// qt Code
    /// </summary>
    public string? QtCode { get; set; }

    /// <summary>
    /// qt 服务 密钥
    /// </summary>
    public string? QtToken { get; set; }

    /// <summary>
    /// ip地址
    /// </summary>
    public string? QtIp { get; set; }

    /// <summary>
    /// 链接动作
    /// </summary>
    public string? QtAction { get; set; }

    /// <summary>
    /// 端口号
    /// </summary>
    public string? QtPort { get; set; }

    /// <summary>
    /// 服务名称
    /// </summary>
    public string? QtName { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? CreateTime { get; set; }

    public short? QtStatus { get; set; }

    /// <summary>
    /// 审核员ID
    /// </summary>
    public int? AuditorId { get; set; }

    public virtual SysUser? Auditor { get; set; }
}
