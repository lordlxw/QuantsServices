using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Favorite
{
    public int Id { get; set; }

    public string Tscode { get; set; } = null!;

    public long? UserId { get; set; }

    public int? OrderNum { get; set; }
}
