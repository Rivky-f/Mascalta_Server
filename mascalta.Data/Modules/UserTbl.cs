using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mascalta.Data.Modules
{
    [Table("user_tbl")]
    public partial class UserTbl
    {
        public UserTbl()
        {
            DocumentTbls = new HashSet<DocumentTbl>();
            MassageTbls = new HashSet<MassageTbl>();
        }

        [Key]
        [Column("idUser")]
        public int IdUser { get; set; }
        [Column("password")]
        [StringLength(8)]
        public string Password { get; set; } = null!;
        [Column("email1")]
        [StringLength(30)]
        public string Email1 { get; set; } = null!;
        [Column("email2")]
        [StringLength(30)]
        public string? Email2 { get; set; }
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
        [Column("firstMeeting", TypeName = "date")]
        public DateTime? FirstMeeting { get; set; }
        [Column("deadline", TypeName = "date")]
        public DateTime? Deadline { get; set; }
        [Column("allDocuments")]
        public int? AllDocuments { get; set; }
        [Column("requestStatus")]
        public int? RequestStatus { get; set; }
        [Column("dealType")]
        public int? DealType { get; set; }
        [Column("comment")]
        [StringLength(100)]
        public string? Comment { get; set; }

        [ForeignKey("DealType")]
        [InverseProperty("UserTbls")]
        public virtual DealTypeTbl? DealTypeNavigation { get; set; }
        [ForeignKey("RequestStatus")]
        [InverseProperty("UserTbls")]
        public virtual RequestStatusTbl? RequestStatusNavigation { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<DocumentTbl> DocumentTbls { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<MassageTbl> MassageTbls { get; set; }
    }
}
