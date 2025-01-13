using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysUserTscode
{
    public long UserId { get; set; }

    public string Tscode { get; set; } = null!;
}
