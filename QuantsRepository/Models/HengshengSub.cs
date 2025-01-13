using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class HengshengSub
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string MarketSubName { get; set; } = null!;

    public short SubType { get; set; }

    public bool? Deleted { get; set; }

    public int? SubId { get; set; }

    public string? SubName { get; set; }
}
