using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("users")]
public partial class User
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("userName")]
    [StringLength(100)]
    public string UserName { get; set; } = null!;

    [Column("firstName")]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Column("middleName")]
    [StringLength(50)]
    public string? MiddleName { get; set; }

    [Column("lastName")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Column("jod")]
    public DateOnly? Jod { get; set; }

    [Column("dob")]
    public DateOnly? Dob { get; set; }

    [Column("email")]
    [StringLength(100)]
    public string? Email { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    public string? Mobile { get; set; }

    [Column("gender")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("password")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Password { get; set; }
}
