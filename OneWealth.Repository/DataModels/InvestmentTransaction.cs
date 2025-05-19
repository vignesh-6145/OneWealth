using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("investmentTransaction")]
public partial class InvestmentTransaction
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("investmentId")]
    public Guid? InvestmentId { get; set; }

    [Column("transactionDate")]
    public DateOnly? TransactionDate { get; set; }

    [Column("amount", TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("units", TypeName = "decimal(18, 4)")]
    public decimal? Units { get; set; }

    [Column("unitPrice", TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [Column("notes")]
    [StringLength(255)]
    public string? Notes { get; set; }

    [Column("paymentMode")]
    [StringLength(50)]
    public string? PaymentMode { get; set; }

    [Column("cardId")]
    public Guid? CardId { get; set; }

    [Column("bankId")]
    public Guid? BankId { get; set; }
}
