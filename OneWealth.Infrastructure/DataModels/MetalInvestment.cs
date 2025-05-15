using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("metalInvestment")]
public partial class MetalInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("metalType")]
    [StringLength(50)]
    public string? MetalType { get; set; }

    [Column("weightInGms", TypeName = "decimal(18, 2)")]
    public decimal? WeightInGms { get; set; }

    [Column("pricePerGm", TypeName = "decimal(18, 2)")]
    public decimal? PricePerGm { get; set; }

    [Column("makingCharges", TypeName = "decimal(18, 2)")]
    public decimal? MakingCharges { get; set; }

    [Column("seller")]
    [StringLength(100)]
    public string? Seller { get; set; }

    [Column("invoiceNumber")]
    [StringLength(30)]
    public string? InvoiceNumber { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Purity { get; set; }
}
