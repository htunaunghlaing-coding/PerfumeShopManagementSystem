using System;
using System.Collections.Generic;

namespace PerfumeShopManagementSystem.Database.Models;

public partial class Perfume
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public int StockQuantity { get; set; }

    public string? PictureUrl { get; set; }

    public string? Longevity { get; set; }

    public string? KeyIngredients { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
