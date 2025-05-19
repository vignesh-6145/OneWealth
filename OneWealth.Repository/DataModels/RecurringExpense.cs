using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("recurringExpense")]
public partial class RecurringExpense
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("startDate")]
    public DateOnly? StartDate { get; set; }

    [Column("frequency")]
    public int? Frequency { get; set; }

    [Column("nextDate")]
    public DateOnly? NextDate { get; set; }

    [Column("lastDate")]
    public DateOnly? LastDate { get; set; }

    [Column("isAutoPaid")]
    public bool? IsAutoPaid { get; set; }
}
