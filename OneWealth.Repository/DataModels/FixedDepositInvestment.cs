using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("fixedDepositInvestment")]
public partial class FixedDepositInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("instructionID")]
    public Guid? InstructionId { get; set; }

    [Column("interestRate", TypeName = "decimal(5, 2)")]
    public decimal? InterestRate { get; set; }

    [Column("maturityDate")]
    public DateOnly? MaturityDate { get; set; }

    [Column("principalAmount", TypeName = "decimal(18, 2)")]
    public decimal? PrincipalAmount { get; set; }

    [Column("maturityAmount", TypeName = "decimal(18, 2)")]
    public decimal? MaturityAmount { get; set; }

    [Column("autoRenewal")]
    public bool? AutoRenewal { get; set; }

    [Column("compounded")]
    public bool? Compounded { get; set; }
}
