using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("expenses")]
public partial class Expense
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("amount", TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("expenseDate")]
    public DateOnly? ExpenseDate { get; set; }

    [Column("category")]
    [StringLength(50)]
    public string? Category { get; set; }

    [Column("paymentMode")]
    [StringLength(50)]
    public string? PaymentMode { get; set; }

    [Column("cardId")]
    public Guid? CardId { get; set; }

    [Column("bankId")]
    public Guid? BankId { get; set; }

    [Column("isRecurring")]
    public bool? IsRecurring { get; set; }

    [Column("expenseType")]
    [StringLength(50)]
    public string? ExpenseType { get; set; }
}
