using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Educations
    {
        [Key]
        public Guid EducationId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string School { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Degree { get; set; }

        [Column(TypeName = "TEXT")]
        public string Description { get; set; }

        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        [JsonIgnore]
        public virtual Resume Resume { get; set; }
    }
}