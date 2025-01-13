using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class FiveMinutePricediffId23
{
    public decimal? Openprice { get; set; }

    public decimal? Closeprice { get; set; }

    public decimal? Highprice { get; set; }

    public decimal? Lowprice { get; set; }

    public string? Tscode { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public int? Volume { get; set; }

    public decimal? Changebp { get; set; }

    public string Name { get; set; } = null!;

    public int? Totalvolume { get; set; }
}
