using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Broker
{
    public int Id { get; set; }

    public string Broker1 { get; set; } = null!;

    public int? Prefer { get; set; }

    public short? Status { get; set; }

    public DateTime? ForbidStart { get; set; }

    public DateTime? ForbidEnd { get; set; }
}
