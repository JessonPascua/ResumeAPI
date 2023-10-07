using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPI.Models
{
    public class Experiences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExperienceId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Title { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Company { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Range { get; set; }
       
        [Column(TypeName = "TEXT")]
        public string Responsibilities { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        public virtual Resume Resume { get; set; }
    }
}