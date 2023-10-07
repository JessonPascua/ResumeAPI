using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPI.Models
{
    public class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CommentId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }

        [Column(TypeName = "TEXT")]
        public string Massage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }

        // Foreign key for Resume
        public Guid ResumeId { get; set; }

        // Navigation property
        [ForeignKey("ResumeId")]
        public virtual Resume Resume { get; set; }
    }
}