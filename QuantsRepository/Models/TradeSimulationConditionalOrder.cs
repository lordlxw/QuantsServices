using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeSimulationConditionalOrder
{
    public int Id { get; set; }

    public string Tscode { get; set; } = null!;

    public int? UsertradeId { get; set; }

    public int UserId { get; set; }

    public short OrderType { get; set; }

    public decimal? PriceConditionPrice { get; set; }

    public short? PriceConditionVolume { get; set; }

    public string? PriceConditionSymbol { get; set; }

    public DateTime? TimeToExecute { get; set; }

    public string DisplayConditionText { get; set; } = null!;

    public string Dealtype { get; set; } = null!;

    public decimal Price { get; set; }

    public short PriceType { get; set; }

    public short? PriceByBidPricetype { get; set; }

    public decimal? Fluctuation { get; set; }

    public string DisplayPriceText { get; set; } = null!;

    public int Volume { get; set; }

    public short OrderResult { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public decimal? StopLossPrice { get; set; }

    public decimal? StopProfitPrice { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime ValidPeriod { get; set; }

    public short? AutoHandleType { get; set; }

    public string? LastAction { get; set; }

    public DateTime? LastActionTime { get; set; }
}
