namespace BlazorApp.Models
{
    public class ExperienceItem
    {
        public string Title { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;        
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Responsibilities { get; set; } = new List<string>();
    }
}
