using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Contacts
    {
        [Key]
        public Guid ContactId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string? Email { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? Phone { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string? GitHub { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string? LinkedIn { get; set; }

        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        //public Guid ResumeId { get; set; }

        //// Navigation property
        //[ForeignKey("ResumeId")]
        //[JsonIgnore]
        //public virtual Resume Resume { get; set; }
    }
}