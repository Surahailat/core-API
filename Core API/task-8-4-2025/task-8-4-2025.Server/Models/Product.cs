using System;
using System.Collections.Generic;

namespace task_8_4_2025.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
