using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Checklist
{
    public int Id { get; set; }

    public string Tscode { get; set; } = null!;

    public DateOnly? Tradedate { get; set; }

    public int? Dbcount { get; set; }

    public int? Qbcount { get; set; }
}
