using System;
using System.Collections.Generic;

namespace Tranport_management_system.Models;

public partial class Register
{
    public int Id { get; set; }

    public string AdminUsername { get; set; } = null!;

    public string AdminName { get; set; } = null!;

    public string AdminPassword { get; set; } = null!;

    public string AdminEmail { get; set; } = null!;

    public string AdminContactNumber { get; set; } = null!;

    public string AdminAgencyName { get; set; } = null!;
}
