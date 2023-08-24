using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("massage_tbl")]
    public partial class MassageTbl
    {
        [Key]
        [Column("idmassage")]
        public int Idmassage { get; set; }
        [Column("idUser")]
        public int IdUser { get; set; }
        [Column("idWriter")]
        public int IdWriter { get; set; }
        [Column("massageContent")]
        public string MassageContent { get; set; } = null!;
        [Column("massageDate", TypeName = "date")]
        public DateTime? MassageDate { get; set; }

        [ForeignKey("IdUser")]
        [InverseProperty("MassageTbls")]
        public virtual UserTbl IdUserNavigation { get; set; } = null!;
    }
}
