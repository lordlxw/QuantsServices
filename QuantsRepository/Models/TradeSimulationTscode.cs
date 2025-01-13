using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulationTscode
{
    public int Id { get; set; }

    public string? Tscode { get; set; }

    public short? Privilege { get; set; }
}
