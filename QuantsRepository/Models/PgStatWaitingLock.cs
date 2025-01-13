using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class PgStatWaitingLock
{
    public string? Locktype { get; set; }

    public int? Pid { get; set; }

    public string? Mode { get; set; }

    public string? Query { get; set; }

    public TimeSpan? Duration { get; set; }
}
