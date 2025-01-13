using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CustomIndexParam
{
    public int Id { get; set; }

    public int IndexId { get; set; }

    public string Param { get; set; } = null!;

    public string? Value { get; set; }

    public virtual CustomIndexList Index { get; set; } = null!;
}
