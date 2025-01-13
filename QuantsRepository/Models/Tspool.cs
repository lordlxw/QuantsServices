using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Tspool
{
    public int Id { get; set; }

    public string Tscode { get; set; } = null!;

    public int Poolid { get; set; }

    public bool? Deleted { get; set; }
}
