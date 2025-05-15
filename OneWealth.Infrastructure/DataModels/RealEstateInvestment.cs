using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("realEstateInvestment")]
public partial class RealEstateInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("location")]
    [StringLength(255)]
    public string? Location { get; set; }

    [Column("propertyType")]
    [StringLength(20)]
    public string? PropertyType { get; set; }

    [Column("estimatedValue", TypeName = "decimal(18, 2)")]
    public decimal? EstimatedValue { get; set; }

    [Column("isRented")]
    public bool? IsRented { get; set; }

    [Column("rent", TypeName = "decimal(18, 2)")]
    public decimal? Rent { get; set; }

    [Column("renatalAgreementstartedOn")]
    public DateOnly? RenatalAgreementstartedOn { get; set; }

    [Column("renatalAgreementExpiresOn")]
    public DateOnly? RenatalAgreementExpiresOn { get; set; }

    [Column("areaInsft", TypeName = "decimal(18, 2)")]
    public decimal? AreaInsft { get; set; }
}
