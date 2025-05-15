using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("equityInvestment")]
public partial class EquityInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("stockSymbol")]
    [StringLength(10)]
    public string? StockSymbol { get; set; }

    [Column("exchange")]
    [StringLength(50)]
    public string? Exchange { get; set; }

    [Column("sector")]
    [StringLength(100)]
    public string? Sector { get; set; }

    [Column("brokerage")]
    [StringLength(100)]
    public string? Brokerage { get; set; }
}
