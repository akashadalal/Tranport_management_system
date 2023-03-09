
using System;
using System.Collections.Generic;

namespace Tranport_management_system.Models;

public partial class Driver
{
    public IEnumerable<Vehicle>Vehicle_name { get; set; }
    public int Id { get; set; }

    public string DriverName { get; set; } = null!;

    public int DriverAge { get; set; }

    public string DriverLic { get; set; } = null!;

    public string DriverContactNumber { get; set; } = null!;
}
