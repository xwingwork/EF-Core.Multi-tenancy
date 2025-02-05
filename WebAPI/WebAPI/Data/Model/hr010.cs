using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data.Model;

[PrimaryKey("comps", "comp", "orgmark", "unino")]
[Table("hr010")]
public partial class hr010
{
    [Key]
    [StringLength(36)]
    public string comps { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string comp { get; set; } = null!;

    [Key]
    [StringLength(8)]
    public string unino { get; set; } = null!;

    [StringLength(100)]
    public string comp_name { get; set; } = null!;

    [StringLength(50)]
    public string comp_name_short { get; set; } = null!;

    [StringLength(200)]
    public string comp_en { get; set; } = null!;

    [Key]
    [MaxLength(1)]
    public char orgmark { get; set; }

    [MaxLength(1)]
    public char lang { get; set; }

    [StringLength(50)]
    public string org_empname { get; set; } = null!;

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(5)]
    public string fiorg { get; set; } = null!;

    [StringLength(12)]
    public string taxid { get; set; } = null!;

    [StringLength(20)]
    public string labno { get; set; } = null!;

    [StringLength(20)]
    public string heano { get; set; } = null!;

    [StringLength(2)]
    public string heano_ar { get; set; } = null!;

    [StringLength(250)]
    public string phone { get; set; } = null!;

    [StringLength(20)]
    public string phone_fax { get; set; } = null!;

    [StringLength(10)]
    public string adzip { get; set; } = null!;

    [StringLength(14)]
    public string adcity { get; set; } = null!;

    [StringLength(16)]
    public string adcity2 { get; set; } = null!;

    [StringLength(1000)]
    public string adother { get; set; } = null!;

    [StringLength(500)]
    public string adother2 { get; set; } = null!;

    [StringLength(8)]
    public string dt_start { get; set; } = null!;

    [StringLength(8)]
    public string dt_stop { get; set; } = null!;

    [StringLength(100)]
    public string website { get; set; } = null!;

    [StringLength(50)]
    public string email { get; set; } = null!;

    [StringLength(8)]
    public string date_modi { get; set; } = null!;

    [StringLength(6)]
    public string time_modi { get; set; } = null!;

    [StringLength(20)]
    public string empno_modi { get; set; } = null!;

    [StringLength(8)]
    public string date_cret { get; set; } = null!;

    [StringLength(6)]
    public string time_cret { get; set; } = null!;

    [StringLength(20)]
    public string empno_cret { get; set; } = null!;

    [StringLength(8)]
    public string date_tran { get; set; } = null!;

    [StringLength(6)]
    public string time_tran { get; set; } = null!;

    [StringLength(20)]
    public string empno_tran { get; set; } = null!;

    [StringLength(50)]
    public string empname_tax { get; set; } = null!;

    [StringLength(12)]
    public string taxid2 { get; set; } = null!;

    [StringLength(10)]
    public string adzip_tax { get; set; } = null!;

    [StringLength(14)]
    public string adcity_tax { get; set; } = null!;

    [StringLength(16)]
    public string adcity2_tax { get; set; } = null!;

    [StringLength(500)]
    public string adother_tax { get; set; } = null!;

    [StringLength(500)]
    public string adother2_tax { get; set; } = null!;

    [StringLength(8)]
    public string? insno { get; set; }

    [StringLength(3)]
    public string? bank { get; set; }

    [StringLength(250)]
    public string? account { get; set; }

    [MaxLength(1)]
    public char? stype3 { get; set; }

    [StringLength(36)]
    public string? app_service_uuid { get; set; }

    [StringLength(5)]
    public string fiorg1 { get; set; } = null!;
}
