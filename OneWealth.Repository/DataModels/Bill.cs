using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("Bill")]
public partial class Bill
{
    [Key]
    public Guid ExpenseId { get; set; }

    [StringLength(100)]
    public string? BillerName { get; set; }

    [StringLength(50)]
    public string? BillNumber { get; set; }

    public DateOnly DueDate { get; set; }

    public bool? LateFeeApplicable { get; set; }
}
