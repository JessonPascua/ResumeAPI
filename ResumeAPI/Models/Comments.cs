using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Comments
    {
        [Key]
        [JsonIgnore]
        public Guid CommentId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "TEXT")]
        public string Massage { get; set; }

        public DateTime? Created_at { get; set; }

        // Foreign key for Resume
        [JsonIgnore]
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        [JsonIgnore]
        public virtual Resume? Resume { get; set; }
    }
}