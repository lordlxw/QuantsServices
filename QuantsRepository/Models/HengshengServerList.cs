using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class HengshengServerList
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Port { get; set; } = null!;

    public string Server { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Tag { get; set; }

    public string Protocol { get; set; } = null!;
}
