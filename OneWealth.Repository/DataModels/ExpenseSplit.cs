using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("expenseSplit")]
public partial class ExpenseSplit
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("expenseId")]
    public Guid? ExpenseId { get; set; }

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("shareAmount", TypeName = "decimal(18, 2)")]
    public decimal? ShareAmount { get; set; }

    [Column("paidOn")]
    public DateOnly? PaidOn { get; set; }

    [Column("isPaid")]
    public bool? IsPaid { get; set; }
}
