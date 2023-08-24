using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("document_tbl")]
    public partial class DocumentTbl
    {
        [Key]
        [Column("idDocument")]
        public int IdDocument { get; set; }
        [Column("nameDocument")]
        [StringLength(30)]
        public string NameDocument { get; set; } = null!;
        [Column("pathDocument")]
        public string PathDocument { get; set; } = null!;
        [Column("uploadDate", TypeName = "date")]
        public DateTime UploadDate { get; set; }
        [Column("comment")]
        [StringLength(30)]
        public string? Comment { get; set; }
        [Column("idUser")]
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        [InverseProperty("DocumentTbls")]
        public virtual UserTbl IdUserNavigation { get; set; } = null!;
    }
}
