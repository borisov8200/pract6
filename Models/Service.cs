using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DurationMinutes { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }
}
