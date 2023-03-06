using System;
using System.Collections.Generic;

namespace Tranport_management_system.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string CustName { get; set; } = null!;

    public int CustAge { get; set; }

    public string CustGender { get; set; } = null!;

    public string CustSeatNumber { get; set; } = null!;

    public string CustContactNumber { get; set; } = null!;

    public string CustDepature { get; set; } = null!;

    public string CustArrivingTo { get; set; } = null!;
}
