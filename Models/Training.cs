using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Training
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Trainer { get; set; } = null!;

    public int DurationMinutes { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }
}
