using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CtdFiveminutePricediff
{
    public string Name { get; set; } = null!;

    public decimal? Openprice { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public decimal? Closeprice { get; set; }

    public DateTime? Endtime { get; set; }

    public string Tscode { get; set; } = null!;

    public string Ctdname { get; set; } = null!;

    public int? Volume { get; set; }
}
