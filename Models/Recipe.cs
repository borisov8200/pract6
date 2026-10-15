using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Cuisine { get; set; } = null!;

    public int CookingTime { get; set; }

    public int Calories { get; set; }

    public bool IsVegetarian { get; set; }
}
