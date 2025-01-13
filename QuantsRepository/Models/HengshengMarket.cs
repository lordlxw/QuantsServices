using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class HengshengMarket
{
    public int Id { get; set; }

    public string MarketName { get; set; } = null!;

    public string? FileName { get; set; }

    public bool? Deleted { get; set; }
}
