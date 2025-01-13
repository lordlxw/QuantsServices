using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CtdOneminutePricediff
{
    public string Name { get; set; } = null!;

    public decimal? Openprice { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public decimal? Closeprice { get; set; }

    public DateTime? Endtime { get; set; }

    public string? Tscode { get; set; }

    public string? Ctdname { get; set; }

    public int? Volume { get; set; }
}
