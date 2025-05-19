using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("tags")]
public partial class Tag
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("tag")]
    [StringLength(50)]
    public string? Tag1 { get; set; }

    [Column("value")]
    [StringLength(50)]
    public string? Value { get; set; }

    [Column("tagType")]
    [StringLength(50)]
    public string? TagType { get; set; }
}
