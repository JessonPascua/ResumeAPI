using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPIwithSupabase.Models
{
    public class Projects
    {
        [Key]
        public Guid ProjectId { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string? Repo { get; set; }
       
        [Column(TypeName = "VARCHAR(100)")]
        public string? Live { get; set; }
        
        [Column(TypeName = "TEXT")]
        public string? Description { get; set; }

        [Column(TypeName = "TEXT[]")]
        public string[]? Stacks { get; set; }

        public DateTime? Created_at { get; set; }

        // Foreign key for Resume
        [JsonIgnore]
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        [JsonIgnore]
        public virtual Resume Resume { get; set; }
    }
}