namespace BlazorApp.Models
{
    public class BasicInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public string? GitHub { get; set; }
        public string? Portfolio { get; set; }
    }
}
