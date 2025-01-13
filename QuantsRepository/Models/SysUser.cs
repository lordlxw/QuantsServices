using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysUser
{
    public int UserId { get; set; }

    public string? DeptId { get; set; }

    public string? UserName { get; set; }

    public string? NickName { get; set; }

    public string? UserType { get; set; }

    public string? Email { get; set; }

    public string? Phonenumber { get; set; }

    public string? Sex { get; set; }

    public string? Avatar { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public string DelFlag { get; set; } = null!;

    public string? LoginIp { get; set; }

    public DateTime? LoginDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }

    public bool? ShowInApp { get; set; }

    public string? Hwinfo { get; set; }

    public int? TradeStatus { get; set; }

    public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();

    public virtual ICollection<ChatPrivilegeList> ChatPrivilegeLists { get; set; } = new List<ChatPrivilegeList>();

    public virtual ICollection<TradeSimulationUser> TradeSimulationUsers { get; set; } = new List<TradeSimulationUser>();

    public virtual ICollection<TradeSimulation> TradeSimulations { get; set; } = new List<TradeSimulation>();

    public virtual ICollection<UserTradeVolumeConfig> UserTradeVolumeConfigs { get; set; } = new List<UserTradeVolumeConfig>();
}
