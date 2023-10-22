using System.ComponentModel.DataAnnotations;

namespace ResumeAPI
{
    public class RoutesList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        [JsonIgnore]
        public string ApiId { get; set; }

        [JsonIgnore]
        public Api Api { get; set; }
    }
}