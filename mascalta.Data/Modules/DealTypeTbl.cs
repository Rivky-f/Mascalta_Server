using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("dealType_tbl")]
    public partial class DealTypeTbl
    {
        public DealTypeTbl()
        {
            ArchiveTbls = new HashSet<ArchiveTbl>();
            UserTbls = new HashSet<UserTbl>();
        }

        [Key]
        [Column("idDeal")]
        public int IdDeal { get; set; }
        [Column("nameDeal")]
        [StringLength(30)]
        public string? NameDeal { get; set; }

        [InverseProperty("DealTypeNavigation")]
        public virtual ICollection<ArchiveTbl> ArchiveTbls { get; set; }
        [InverseProperty("DealTypeNavigation")]
        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
