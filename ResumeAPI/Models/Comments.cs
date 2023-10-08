using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Comments
    {
        [Key]
        public Guid CommentId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }

        [Column(TypeName = "TEXT")]
        public string Massage { get; set; }
        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        [JsonIgnore]
        public virtual Resume Resume { get; set; }
    }
}