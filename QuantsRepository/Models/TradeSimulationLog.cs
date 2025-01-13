using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulationLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateTime? LogDate { get; set; }

    public string? Action { get; set; }

    public string? LogData { get; set; }

    public string? RemoteIp { get; set; }

    public string? Message { get; set; }
}
