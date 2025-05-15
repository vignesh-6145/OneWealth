using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("bankInstruction")]
public partial class BankInstruction
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("accountNumber")]
    [StringLength(18)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("accountType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccountType { get; set; }

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("bankName")]
    [StringLength(100)]
    public string? BankName { get; set; }

    [Column("branch")]
    [StringLength(100)]
    public string? Branch { get; set; }

    [Column("ifsc")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Ifsc { get; set; }

    [Column("isPrimary")]
    public bool? IsPrimary { get; set; }
}
