using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChannelManageLog
{
    public string Id { get; set; } = null!;

    public string? Operation { get; set; }

    public string? Reason { get; set; }

    public string? ChannelId { get; set; }

    public string? BrokerId { get; set; }

    public string? OccupyId { get; set; }

    public bool? IsForce { get; set; }

    public DateTime? CreateTime { get; set; }
}
