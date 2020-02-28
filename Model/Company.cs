using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreScaffoldExample.Model
{
    public partial class Company
    {
        [Column("CompanyID")]
        public long CompanyId { get; set; }
        [Column("Company Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Column("Company Author")]
        [StringLength(50)]
        public string CompanyAuthor { get; set; }
        [Column("Company Address")]
        public string CompanyAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [MaxLength(50)]
        public byte[] UpdatedBy { get; set; }
    }
}
