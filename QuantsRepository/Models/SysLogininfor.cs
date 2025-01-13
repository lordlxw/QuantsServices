using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysLogininfor
{
    public long InfoId { get; set; }

    public string? UserName { get; set; }

    public string? Ipaddr { get; set; }

    public string? LoginLocation { get; set; }

    public string? Browser { get; set; }

    public string? Os { get; set; }

    public string? Status { get; set; }

    public string? Msg { get; set; }

    public DateTime? LoginTime { get; set; }

    public string? Hwinfo { get; set; }
}
