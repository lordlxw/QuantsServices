using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysColumn
{
    public int ColumnId { get; set; }

    public string? ColumnKey { get; set; }

    public string? ColumnValue { get; set; }

    public int? TemplateId { get; set; }

    public int? OrderNum { get; set; }
}
