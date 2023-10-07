using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPI.Models
{
    public class Contacts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ContactId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? Email { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? Phone { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? GitHub { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? LinkedIn { get; set; }

        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        public virtual Resume Resume { get; set; }
    }
}