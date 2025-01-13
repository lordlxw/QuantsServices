using System;
using System.Collections.Generic;

namespace QuantsRepository.Models;

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? ParentId { get; set; }
}
