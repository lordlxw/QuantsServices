using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public DateTime TradeDate { get; set; }

    public string Tscode { get; set; } = null!;
}
