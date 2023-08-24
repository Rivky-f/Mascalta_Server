using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("requestStatus_tbl")]
    public partial class RequestStatusTbl
    {
        public RequestStatusTbl()
        {
            UserTbls = new HashSet<UserTbl>();
        }

        [Key]
        [Column("idStatus")]
        public int IdStatus { get; set; }
        [Column("nameStatus")]
        [StringLength(30)]
        public string? NameStatus { get; set; }

        [InverseProperty("RequestStatusNavigation")]
        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
