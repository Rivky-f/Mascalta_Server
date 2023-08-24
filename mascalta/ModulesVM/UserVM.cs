using mascalta.Data.Modules;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mascalta.Core.ModulesVM
{
    internal class UserVM
    {
        public int IdUser { get; set; }
        public string Password { get; set; } = null!;
        public string Email1 { get; set; } = null!;
        public string? Email2 { get; set; }
        public string? FirstName1 { get; set; }
        public string? FirstName2 { get; set; }
        public string? LastName { get; set; }
        public string? Tz1 { get; set; }
        public string? Tz2 { get; set; }
        public string? AddressUser { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public DateTime? FirstMeeting { get; set; }
        public DateTime? Deadline { get; set; }
        public int? AllDocuments { get; set; }
        public int? RequestStatus { get; set; }
        public int? DealType { get; set; }
        public string? Comment { get; set; }
    }
}
