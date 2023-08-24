using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("archive_tbl")]
    public partial class ArchiveTbl
    {
        [Key]
        [Column("idUser")]
        public int IdUser { get; set; }
        [Column("firstName1")]
        [StringLength(10)]
        public string? FirstName1 { get; set; }
        [Column("firstName2")]
        [StringLength(10)]
        public string? FirstName2 { get; set; }
        [Column("lastName")]
        [StringLength(15)]
        public string? LastName { get; set; }
        [Column("tz1")]
        [StringLength(9)]
        public string? Tz1 { get; set; }
        [Column("tz2")]
        [StringLength(9)]
        public string? Tz2 { get; set; }
        [Column("addressUser")]
        [StringLength(30)]
        public string? AddressUser { get; set; }
        [Column("phone1")]
        [StringLength(10)]
        public string? Phone1 { get; set; }
        [Column("phone2")]
        [StringLength(10)]
        public string? Phone2 { get; set; }
        [Column("email1")]
        [StringLength(30)]
        public string? Email1 { get; set; }
        [Column("email2")]
        [StringLength(30)]
        public string? Email2 { get; set; }
        [Column("firstMeeting", TypeName = "date")]
        public DateTime? FirstMeeting { get; set; }
        [Column("dateAddArchive", TypeName = "date")]
        public DateTime? DateAddArchive { get; set; }
        [Column("dealType")]
        public int? DealType { get; set; }
        [Column("comment")]
        [StringLength(100)]
        public string? Comment { get; set; }

        [ForeignKey("DealType")]
        [InverseProperty("ArchiveTbls")]
        public virtual DealTypeTbl? DealTypeNavigation { get; set; }
    }
}
