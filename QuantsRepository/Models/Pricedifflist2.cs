using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Pricedifflist2
{
    public int Id { get; set; }

    public string Tscode1 { get; set; } = null!;

    public string Tscode2 { get; set; } = null!;

    public bool? Working { get; set; }

    public bool? Deleted { get; set; }

    public string? Name { get; set; }

    public string? Tdxcode { get; set; }

    public string? HengshengId { get; set; }

    public string? HengshengName { get; set; }

    public short? Poolid { get; set; }
}
