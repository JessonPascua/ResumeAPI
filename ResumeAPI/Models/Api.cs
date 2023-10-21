namespace ResumeAPI.Models
{
    public class Api
    {
        [Key]
        public string Id { get; set; }
        public List<RoutesList> RoutesList { get; set; }
    }
}