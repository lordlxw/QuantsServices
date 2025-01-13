using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TempSourceOrderWind
{
    public string Source { get; set; } = null!;

    public short Order { get; set; }
}
