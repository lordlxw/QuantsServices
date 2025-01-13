using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class LatestbidUnloged
{
    public string? Tscode { get; set; }

    public string? Volume { get; set; }

    public decimal? Price { get; set; }

    public string? Updatetime { get; set; }

    public DateTime? Updatedatetime { get; set; }

    public int? Brokerid { get; set; }

    public int? Bidtype { get; set; }

    public int? Barginflag { get; set; }

    public string? Volumecomment { get; set; }

    public decimal? Lasttransaction { get; set; }

    public decimal? Netprice { get; set; }
}
