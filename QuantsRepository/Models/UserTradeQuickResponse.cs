using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserTradeQuickResponse
{
    public int Id { get; set; }

    public string Response { get; set; } = null!;
}
