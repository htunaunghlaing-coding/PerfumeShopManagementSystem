using System;
using System.Collections.Generic;

namespace PerfumeShopManagementSystem.Database.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int PerfumeId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Perfume Perfume { get; set; } = null!;
}
