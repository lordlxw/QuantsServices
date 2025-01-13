using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class PushMessage
{
    public string MessageId { get; set; } = null!;

    public string? Message { get; set; }

    public string? Type { get; set; }

    public DateTime? PushTime { get; set; }

    public int? Status { get; set; }
}
