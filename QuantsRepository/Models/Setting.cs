using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Setting
{
    public int Id { get; set; }

    public string Parameter { get; set; } = null!;

    public string Value { get; set; } = null!;
}
