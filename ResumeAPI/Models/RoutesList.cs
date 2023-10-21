using System.ComponentModel.DataAnnotations;

namespace ResumeAPI
{
    public class RoutesList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public string ApiId { get; set; }
        public Api Api { get; set; }
    }
}