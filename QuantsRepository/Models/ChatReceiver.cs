using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChatReceiver
{
    public string? Target { get; set; }

    public string? Company { get; set; }

    public string? Tscode { get; set; }

    public string? ChatId { get; set; }

    public bool? Deleted { get; set; }

    public string? GroupName { get; set; }

    public short? Brokerid { get; set; }

    public int Id { get; set; }

    public string? ChannelId { get; set; }

    public short? Status { get; set; }

    public DateTime? ForbidStart { get; set; }

    public DateTime? ForbidEnd { get; set; }
}
