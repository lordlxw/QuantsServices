using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysRole
{
    public long RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? RoleKey { get; set; }

    public string? RoleSort { get; set; }

    public string? DataScope { get; set; }

    public string? MenuCheckStrictly { get; set; }

    public string? DeptCheckStrictly { get; set; }

    public string? Status { get; set; }

    public string? DelFlag { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }
}
