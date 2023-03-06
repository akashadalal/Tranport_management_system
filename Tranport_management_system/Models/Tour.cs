using System;
using System.Collections.Generic;

namespace Tranport_management_system.Models;

public partial class Tour
{
    public int Id { get; set; }

    public string DeptName { get; set; } = null!;

    public string ArrivalName { get; set; } = null!;
}
