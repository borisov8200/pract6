using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int PublishYear { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}
