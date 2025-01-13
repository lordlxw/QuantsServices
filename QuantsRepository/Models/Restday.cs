using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Restday
{
    public int Id { get; set; }

    public DateOnly Holiday { get; set; }
}
