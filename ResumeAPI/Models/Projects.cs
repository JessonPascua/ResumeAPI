using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ResumeAPI.Models
{
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProjectId { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string ProjectName { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string? Repo { get; set; }
       
        [Column(TypeName = "VARCHAR(100)")]
        public string? Live { get; set; }
        
        [Column(TypeName = "TEXT")]
        public string? Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        [JsonIgnore]
        public virtual Resume Resume { get; set; }
    }
}