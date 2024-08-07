﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPIwithSupabase.Models
{
    public class Resume
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string AboutMe { get; set; }

        public virtual ICollection<Experiences> Experiences { get; set; }
        public virtual ICollection<Educations> Educations { get; set; }
        public virtual ICollection<Certifications> Certifications { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
