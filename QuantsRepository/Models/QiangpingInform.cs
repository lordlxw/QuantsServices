using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class QiangpingInform
{
    public long? UserId { get; set; }

    public int? Status { get; set; }

    public DateTime? StartTime { get; set; }

    public int? Duration { get; set; }

    public string? Message { get; set; }

    public DateTime? CreateTime { get; set; }

    public bool? Consumed { get; set; }

    public string MessageId { get; set; } = null!;
}
