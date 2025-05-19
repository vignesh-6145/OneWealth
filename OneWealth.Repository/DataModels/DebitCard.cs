using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("debitCard")]
public partial class DebitCard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("instructionId")]
    public Guid? InstructionId { get; set; }

    [Column("dailyLimit", TypeName = "decimal(18, 2)")]
    public decimal? DailyLimit { get; set; }

    [Column("atmLimit", TypeName = "decimal(18, 2)")]
    public decimal? AtmLimit { get; set; }
}
