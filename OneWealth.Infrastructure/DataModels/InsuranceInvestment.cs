using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("insuranceInvestment")]
public partial class InsuranceInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("policyNumber")]
    [StringLength(30)]
    public string? PolicyNumber { get; set; }

    [Column("policyType")]
    [StringLength(30)]
    public string? PolicyType { get; set; }

    [Column("sumAssured", TypeName = "decimal(18, 2)")]
    public decimal? SumAssured { get; set; }

    [Column("insurerName")]
    [StringLength(100)]
    public string? InsurerName { get; set; }

    [Column("policyEndDate")]
    public DateOnly? PolicyEndDate { get; set; }

    [Column("isTaxSaving")]
    public bool? IsTaxSaving { get; set; }
}
