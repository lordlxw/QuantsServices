using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Spreadcurve
{
    public string? Length { get; set; }

    public int? Curvetype { get; set; }

    public DateOnly? Tradedate { get; set; }

    public decimal? Value { get; set; }
}
