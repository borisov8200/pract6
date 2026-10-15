using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string InventoryNumber { get; set; } = null!;

    public decimal Price { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public bool IsOperational { get; set; }
}
