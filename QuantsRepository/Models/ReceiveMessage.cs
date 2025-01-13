using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ReceiveMessage
{
    public string MessageId { get; set; } = null!;

    public string? Message { get; set; }

    public DateTime? RecTime { get; set; }
}
