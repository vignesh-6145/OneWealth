using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("investments")]
public partial class Investment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("name")]
    [StringLength(100)]
    public string? Name { get; set; }

    [Column("nominee")]
    public Guid? Nominee { get; set; }

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("startedOn")]
    public DateOnly? StartedOn { get; set; }

    [Column("isPeriodic")]
    public bool? IsPeriodic { get; set; }

    [Column("frequency")]
    public int? Frequency { get; set; }

    [Column("investmentType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InvestmentType { get; set; }
}
