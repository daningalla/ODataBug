using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataBug
{
    [Table("Tenant", Schema = "TenantData")]
    public partial class Tenant
    {
        [Key]
        public int Id { get; set; }
        public Guid TenantGuid { get; set; }
        public Guid CompanyGuid { get; set; }        
        [StringLength(255)]
        public string CompanyName { get; set; }
        [StringLength(255)]
        public string TenantName { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public Guid? ChangedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangedDate { get; set; }
    }
}