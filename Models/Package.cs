using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Package
{
    public int Id { get; set; }

    public string TrackingNumber { get; set; } = null!;

    public string Recipient { get; set; } = null!;

    public decimal Weight { get; set; }

    public string Status { get; set; } = null!;

    public bool IsDelivered { get; set; }
}
