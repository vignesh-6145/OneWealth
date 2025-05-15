using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("creditCard")]
public partial class CreditCard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("creditLimit", TypeName = "decimal(18, 2)")]
    public decimal? CreditLimit { get; set; }

    [Column("interest", TypeName = "decimal(5, 2)")]
    public decimal? Interest { get; set; }

    [Column("billingDate")]
    public DateOnly? BillingDate { get; set; }

    [Column("dueDate")]
    public DateOnly? DueDate { get; set; }

    [Column("gracePeriod")]
    public int? GracePeriod { get; set; }
}
