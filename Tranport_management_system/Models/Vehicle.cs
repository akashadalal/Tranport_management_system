using System;
using System.Collections.Generic;

namespace Tranport_management_system.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string VehName { get; set; } = null!;

    public string VehNumber { get; set; } = null!;

    public string VehModel { get; set; } = null!;

    public string VehStatus { get; set; } = null!;

    public string VehColor { get; set; } = null!;
}
