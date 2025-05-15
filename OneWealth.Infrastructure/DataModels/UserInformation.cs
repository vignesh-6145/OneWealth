using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("user_information")]
public partial class UserInformation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("pan")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Pan { get; set; }

    [Column("aadhar")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Aadhar { get; set; }

    [Column("addressLine_1")]
    [StringLength(255)]
    public string? AddressLine1 { get; set; }

    [Column("addressLine_2")]
    [StringLength(255)]
    public string? AddressLine2 { get; set; }

    [Column("city")]
    [StringLength(50)]
    public string? City { get; set; }

    [Column("country")]
    [StringLength(50)]
    public string? Country { get; set; }

    [Column("pincode")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Pincode { get; set; }
}
