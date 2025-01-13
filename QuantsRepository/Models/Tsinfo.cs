using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Tsinfo
{
    public string Tscode { get; set; } = null!;

    public DateOnly Startdate { get; set; }

    public string Bondkey { get; set; } = null!;

    public DateOnly? Lastdaycrawled { get; set; }

    public string Bondname { get; set; } = null!;

    public string? Listedmarket { get; set; }

    public string? Bondrating { get; set; }

    public bool? Deleted { get; set; }

    public string? Issuerate { get; set; }

    public string? Issueamount { get; set; }

    public string? Issueprice { get; set; }

    public string? Maturity { get; set; }

    public DateOnly? Maturitydate { get; set; }

    public string? Bondfullname { get; set; }

    public bool? Realtime { get; set; }

    public short? Interestperyear { get; set; }

    public DateTime? Lastdaycrawledtime { get; set; }

    public DateOnly? Qbdate { get; set; }

    public DateOnly? Firsttradedate { get; set; }

    public DateOnly? Intereststartdate { get; set; }

    public int Id { get; set; }

    public short? Poolid { get; set; }

    public decimal? Basicvalue { get; set; }

    public string? HengshengId { get; set; }

    public string? HengshengName { get; set; }
}
