namespace BlazorApp.Models
{
    public class EducationItem
    {
        public string Title { get; set; } = string.Empty;
        public string InstitutionName { get; set; } = string.Empty;
        public string Location {  get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Achievements { get; set; } = new List<string>();
    }
}
