using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChatPrivilegeList
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? BrokerList { get; set; }

    public string? UserName { get; set; }

    public virtual SysUser User { get; set; } = null!;
}
