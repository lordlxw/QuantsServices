using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserProfile
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public string? Wins { get; set; }

    public bool? IsKlineSubmit { get; set; }

    public long? DefVolume { get; set; }

    public string? KlineColor { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? DailyLine { get; set; }

    public string? Chats { get; set; }
}
