using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Apartment
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public int Rooms { get; set; }

    public decimal Area { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}
