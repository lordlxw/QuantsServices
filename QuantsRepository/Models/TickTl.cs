using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TickTl
{
    public DateTime? BusinessTime { get; set; }

    public decimal? HqPx { get; set; }

    public int? BusinessAmount { get; set; }

    public long? BusinessBalance { get; set; }

    public int? BusinessCount { get; set; }

    public int? BusinessDirection { get; set; }

    public int? Amount { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? ProductCode { get; set; }
}
