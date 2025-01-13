using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class TradeOperationTrack
{
    public long Id { get; set; }

    public string? FromNum { get; set; }

    public string? Operation { get; set; }

    public string? OperationCode { get; set; }

    public string? OperationField { get; set; }

    public string? OperationValue { get; set; }

    public string? ToNum { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public long? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }
}
