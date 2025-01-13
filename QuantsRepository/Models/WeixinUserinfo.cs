using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class WeixinUserinfo
{
    public long? UserId { get; set; }

    public string OpenId { get; set; } = null!;

    public string? UnionId { get; set; }

    public string? NickName { get; set; }

    public bool? Vip { get; set; }
}
