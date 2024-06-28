using Postgrest.Attributes;
using Postgrest.Models;

namespace ResumeAPIwithSupabase.Models;

[Table("api")]
public class Api : BaseModel
{
    [PrimaryKey("id", false)]
    public string Id { get; set; }
    public List<RoutesList> RoutesList { get; set; }
}