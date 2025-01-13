using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserProfitDetail
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Jinrifuying { get; set; }

    public decimal? Jinriguying { get; set; }

    public decimal? Leijiguying { get; set; }
}
