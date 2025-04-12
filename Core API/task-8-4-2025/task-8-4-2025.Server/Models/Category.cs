using System;
using System.Collections.Generic;

namespace task_8_4_2025.Server.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Descrebtion { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
