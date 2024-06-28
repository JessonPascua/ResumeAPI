using Newtonsoft.Json;
using Postgrest.Attributes;
using Postgrest.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeAPIwithSupabase.Models
{
    public class RoutesList : BaseModel
    {
        [PrimaryKey("id", false)]
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