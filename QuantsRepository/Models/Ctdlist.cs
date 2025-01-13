using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Ctdlist
{
    public int Id { get; set; }

    public string Tscode { get; set; } = null!;

    public string Ctd { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Deleted { get; set; }
}
