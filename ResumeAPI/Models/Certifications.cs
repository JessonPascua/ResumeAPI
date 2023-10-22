namespace ResumeAPI.Models
{
    public class Certifications
    {
        [Key]
        public Guid CertificationId { get; set; }

        [Column(TypeName = "VARCHAR(525)")]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(100)")]
        public string Issuer { get; set; }

        [Column(TypeName = "Date")]
        public DateTime IssueDate { get; set; }

        [Column(TypeName = "VARCHAR(225)")]
        public string CredentialURL { get; set; }

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