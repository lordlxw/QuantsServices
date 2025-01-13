using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysMenu
{
    public long MenuId { get; set; }

    public string? MenuName { get; set; }

    public long? ParentId { get; set; }

    public string? OrderNum { get; set; }

    public string? Path { get; set; }

    public string? Component { get; set; }

    public string? IsFrame { get; set; }

    public string? IsCache { get; set; }

    public string? MenuType { get; set; }

    public string? Visible { get; set; }

    public string? Status { get; set; }

    public string? Perms { get; set; }

    public string? Icon { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }
}
