using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Tour
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int DurationDays { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}
