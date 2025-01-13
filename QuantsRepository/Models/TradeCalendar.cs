using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeCalendar
{
    public DateOnly Date { get; set; }

    public bool? Isbankwork { get; set; }

    public bool? Frontend { get; set; }

    public bool? Middle { get; set; }

    public bool? Backend { get; set; }

    public int? Maxdays { get; set; }

    public bool? Pingcang { get; set; }

    public bool? Feiyingwork { get; set; }
}
