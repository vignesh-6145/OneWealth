using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Infrastructure.DataModels;

[Table("card")]
public partial class Card
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("cardName")]
    [StringLength(100)]
    public string? CardName { get; set; }

    [Column("nameOnCard")]
    [StringLength(100)]
    public string? NameOnCard { get; set; }

    [Column("cardNumer")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CardNumer { get; set; }

    [Column("expiry")]
    public DateOnly? Expiry { get; set; }

    [Column("network")]
    [StringLength(50)]
    public string? Network { get; set; }

    [Column("status")]
    public bool? Status { get; set; }

    [Column("cardType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CardType { get; set; }
}
