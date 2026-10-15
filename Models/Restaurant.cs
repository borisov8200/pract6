using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Cuisine { get; set; } = null!;

    public decimal Rating { get; set; }

    public decimal AverageCheck { get; set; }

    public bool IsOpen { get; set; }
}
