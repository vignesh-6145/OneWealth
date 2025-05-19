using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OneWealth.Repository.DataModels;

[Table("mutualFundInvestment")]
public partial class MutualFundInvestment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("fundName")]
    [StringLength(100)]
    public string? FundName { get; set; }

    [Column("fundType")]
    [StringLength(50)]
    public string? FundType { get; set; }

    [Column("folioNumber")]
    [StringLength(30)]
    public string? FolioNumber { get; set; }

    [Column("amcFirm")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AmcFirm { get; set; }

    [Column("registrar")]
    [StringLength(50)]
    public string? Registrar { get; set; }

    [Column("modeOfInvestment")]
    [StringLength(50)]
    public string? ModeOfInvestment { get; set; }
}
