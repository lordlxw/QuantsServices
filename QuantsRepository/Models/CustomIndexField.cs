using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CustomIndexField
{
    public int Id { get; set; }

    public int? IndexId { get; set; }

    public string Field { get; set; } = null!;

    public short Drawtype { get; set; }

    public virtual CustomIndexList? Index { get; set; }
}
