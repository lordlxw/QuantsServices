using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class HengshengServerDetail
{
    public int Id { get; set; }

    public int ServerId { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
