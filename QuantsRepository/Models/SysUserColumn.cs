using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysUserColumn
{
    public long UserId { get; set; }

    public int? TemplateId { get; set; }

    public string? HeadContent { get; set; }

    public string? FieldValue { get; set; }
}
