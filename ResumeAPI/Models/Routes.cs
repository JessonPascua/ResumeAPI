using System.ComponentModel.DataAnnotations;

namespace ResumeAPI
{
    public class Routes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        [ForeignKey("RouteId")]
        public string RouteId { get; set; }
    }
}