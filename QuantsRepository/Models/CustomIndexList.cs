using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class CustomIndexList
{
    public int Id { get; set; }

    public string IndexName { get; set; } = null!;

    public string? ZhName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CustomIndexField> CustomIndexFields { get; set; } = new List<CustomIndexField>();

    public virtual ICollection<CustomIndexParam> CustomIndexParams { get; set; } = new List<CustomIndexParam>();
}
