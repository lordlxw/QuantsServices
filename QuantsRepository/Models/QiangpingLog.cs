using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class QiangpingLog
{
    public string QiangpingId { get; set; } = null!;

    public long? UsertradeId { get; set; }

    public string? Operation { get; set; }

    public string? Phase { get; set; }

    public string? MessageId { get; set; }

    public DateTime? CreateTime { get; set; }
}
