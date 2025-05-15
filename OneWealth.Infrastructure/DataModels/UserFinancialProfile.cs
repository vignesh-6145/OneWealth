using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("user_financial_profile")]
public partial class UserFinancialProfile
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("annualIncome", TypeName = "decimal(18, 2)")]
    public decimal? AnnualIncome { get; set; }

    [Column("title")]
    [StringLength(100)]
    public string? Title { get; set; }

    [Column("emplpoyer")]
    [StringLength(100)]
    public string? Emplpoyer { get; set; }

    [Column("investmentGoal")]
    [StringLength(255)]
    public string? InvestmentGoal { get; set; }
}
