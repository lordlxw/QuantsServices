using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class QiangpingLock
{
    public string? Tscode { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public long? UserId { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public DateTime? LockTime { get; set; }

    public DateTime? UnlockTime { get; set; }

    public string? DeliverySpeed { get; set; }
}
