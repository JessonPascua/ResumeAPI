namespace ResumeAPI.Models
{
    public class Api
    {
        [Key]
        public Guid Id { get; set; }
        public string[] routes { get; set; }
        public virtual List<Routes> Routes { get; set; }
    }
}