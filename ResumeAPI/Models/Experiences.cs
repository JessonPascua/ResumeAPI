using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Experiences
    {
        [Key]
        public Guid ExperienceId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Title { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Company { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Range { get; set; }

        [Column(TypeName = "TEXT[]")]
        public string[]? Responsibilities { get; set; }
        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        //public Guid ResumeId { get; set; }

        //// Navigation property
        //[ForeignKey("ResumeId")]
        //[JsonIgnore]
        //public virtual Resume Resume { get; set; }
    }
}