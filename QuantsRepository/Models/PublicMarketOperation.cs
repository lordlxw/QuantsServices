using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class PublicMarketOperation
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Duration { get; set; }

    public string? Amount { get; set; }

    public string? Rate { get; set; }

    public DateOnly? Date { get; set; }

    public string? Type { get; set; }

    public DateTime? Createtime { get; set; }

    public string? Unit { get; set; }
}
