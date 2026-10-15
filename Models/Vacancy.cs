using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Vacancy
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Company { get; set; } = null!;

    public decimal Salary { get; set; }

    public string City { get; set; } = null!;

    public bool IsActive { get; set; }
}
