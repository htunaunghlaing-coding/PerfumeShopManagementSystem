using System;
using System.Collections.Generic;

namespace PerfumeShopManagementSystem.Database.Models;

public partial class Report
{
    public int Id { get; set; }

    public string ReportType { get; set; } = null!;

    public string? ReportData { get; set; }

    public DateTime GeneratedAt { get; set; }
}
