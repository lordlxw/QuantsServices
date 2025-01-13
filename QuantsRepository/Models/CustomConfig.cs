using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CustomConfig
{
    public string? Client { get; set; }

    public string? Type { get; set; }

    public string? Data { get; set; }

    public long? UserId { get; set; }

    public string? Key { get; set; }
}
