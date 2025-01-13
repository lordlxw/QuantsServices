using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class JiaogeOperationTrack
{
    public string? FinishCodes { get; set; }

    public string? Weiyue { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }
}
