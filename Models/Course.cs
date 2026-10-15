using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Teacher { get; set; } = null!;

    public int DurationHours { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }
}
