using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysTradeAmountLimit
{
    public int Id { get; set; }

    public long UserId { get; set; }

    public int Level { get; set; }

    public DateTime LastChangeDate { get; set; }
}
