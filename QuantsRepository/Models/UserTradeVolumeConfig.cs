using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class UserTradeVolumeConfig
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Tscode { get; set; } = null!;

    public int Volume { get; set; }

    public virtual SysUser User { get; set; } = null!;
}
