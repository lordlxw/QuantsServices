using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CustomConfigAuth
{
    public string? Client { get; set; }

    public string? Type { get; set; }

    public int? Status { get; set; }

    public short? Needkey { get; set; }

    public string? DefaultConfig { get; set; }
}
