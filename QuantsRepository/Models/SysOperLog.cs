using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class SysOperLog
{
    public long OperId { get; set; }

    public string? Title { get; set; }

    public string? BusinessType { get; set; }

    public string? Method { get; set; }

    public string? RequestMethod { get; set; }

    public string? OperatorType { get; set; }

    public string? OperName { get; set; }

    public string? DeptName { get; set; }

    public string? OperUrl { get; set; }

    public string? OperIp { get; set; }

    public string? OperLocation { get; set; }

    public string? OperParam { get; set; }

    public string? JsonResult { get; set; }

    public string? Status { get; set; }

    public string? ErrorMsg { get; set; }

    public DateTime? OperTime { get; set; }
}
