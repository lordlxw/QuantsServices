using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserTradeBondhelper
{
    public long Id { get; set; }

    public string Tscode { get; set; } = null!;

    public long UserTradeId { get; set; }

    public decimal Price { get; set; }

    public int Volume { get; set; }

    public string Broker { get; set; } = null!;

    public string Chatid { get; set; } = null!;

    public int Userid { get; set; }

    public short Status { get; set; }

    public DateOnly Deliverydate { get; set; }

    public DateTime Time { get; set; }

    public string Dealtype { get; set; } = null!;

    public int? ReceiverId { get; set; }

    public string? Command { get; set; }

    public short? OrderType { get; set; }

    public Guid? Guid { get; set; }

    public short? DailyId { get; set; }

    public string? RestVolume { get; set; }

    public short? BrokerId { get; set; }

    public virtual ICollection<ReviewMessage> ReviewMessages { get; set; } = new List<ReviewMessage>();
}
