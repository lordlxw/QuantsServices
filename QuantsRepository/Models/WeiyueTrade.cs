using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class WeiyueTrade
{
    public long Id { get; set; }

    public string? Tscode { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public long? RealTradeId { get; set; }

    public int? DeleteFlag { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public long? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 违约方
    /// </summary>
    public string? WeiyuePerson { get; set; }

    /// <summary>
    /// 违约类型，0是技术，1是恶意
    /// </summary>
    public int? WeiyueType { get; set; }

    /// <summary>
    /// 违约数量
    /// </summary>
    public int? WeiyueAmount { get; set; }

    /// <summary>
    /// 做市商名称
    /// </summary>
    public string? MarketMakerName { get; set; }

    public string? FinishCode { get; set; }
}
