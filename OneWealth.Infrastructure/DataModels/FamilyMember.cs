using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("family_members")]
public partial class FamilyMember
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("familyId")]
    public Guid? FamilyId { get; set; }

    [Column("memberId")]
    public Guid? MemberId { get; set; }

    [Column("role")]
    [StringLength(50)]
    public string? Role { get; set; }
}
