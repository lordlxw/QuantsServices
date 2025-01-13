using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class ChannelBindUser
{
    public string? ChannelId { get; set; }

    public long? UserId { get; set; }
}
