using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class BidhistoryId22
{
    public string Tscode { get; set; } = null!;

    public string? Volume { get; set; }

    public decimal? Price { get; set; }

    public string? Updatetime { get; set; }

    public DateTime? Updatedatetime { get; set; }

    public int? Brokerid { get; set; }

    public short? Bidtype { get; set; }

    public int? Totalvolume { get; set; }

    public bool? Valid { get; set; }

    public short? Barginflag { get; set; }

    public string? Volumecomment { get; set; }

    public decimal? Lasttransaction { get; set; }

    public bool? Forwardbid { get; set; }

    public string? Bidid { get; set; }

    public int Id { get; set; }

    public string? Comment { get; set; }

    public TimeOnly? ServerTime { get; set; }
}
