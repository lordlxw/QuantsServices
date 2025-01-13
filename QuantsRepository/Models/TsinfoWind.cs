using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TsinfoWind
{
    public int Id { get; set; }

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

    public DateOnly? Nextinterestday { get; set; }

    public short? Interestperyear { get; set; }

    public DateOnly? Qbdate { get; set; }
}
