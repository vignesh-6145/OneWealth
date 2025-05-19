using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("pensionInvestment")]
public partial class PensionInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("currentValue", TypeName = "decimal(18, 2)")]
    public decimal? CurrentValue { get; set; }

    [Column("instructionId")]
    public Guid? InstructionId { get; set; }

    [Column("pensionType")]
    [StringLength(100)]
    public string? PensionType { get; set; }

    [Column("pran")]
    [StringLength(20)]
    public string? Pran { get; set; }

    [Column("uan")]
    [StringLength(20)]
    public string? Uan { get; set; }

    [Column("tier")]
    [StringLength(10)]
    public string? Tier { get; set; }

    [Column("monthlyContribution", TypeName = "decimal(18, 2)")]
    public decimal? MonthlyContribution { get; set; }

    [Column("employerContribution", TypeName = "decimal(18, 2)")]
    public decimal? EmployerContribution { get; set; }

    [Column("lockedInPeriod")]
    public int? LockedInPeriod { get; set; }
}
