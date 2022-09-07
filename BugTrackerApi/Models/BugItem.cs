namespace BugTrackerApi.Models
{
    public class BugItem
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public bool IsComplete { get; set; }
    }
}
