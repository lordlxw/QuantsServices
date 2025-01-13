using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Tspoolinfo
{
    public int Id { get; set; }

    public short Tstype { get; set; }

    public short Tslength { get; set; }

    public string? HengshengId { get; set; }

    public string? HengshengName { get; set; }
}
