using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int ReleaseYear { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}
