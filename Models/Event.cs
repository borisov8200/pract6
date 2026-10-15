using System;
using System.Collections.Generic;

namespace pract6_Borisov.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public decimal TicketPrice { get; set; }

    public bool IsActive { get; set; }
}
