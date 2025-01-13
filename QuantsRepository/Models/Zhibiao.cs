using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Zhibiao
{
    public string ZhibiaoId { get; set; } = null!;

    public string? ZhibiaoCode { get; set; }

    public string? ZhibiaoName { get; set; }

    public string? Value { get; set; }

    public string? Strdate { get; set; }

    public DateTime? Date { get; set; }

    public string? Zbtype { get; set; }

    public string? Sjtype { get; set; }

    public string? Valid { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Remark { get; set; }
}
