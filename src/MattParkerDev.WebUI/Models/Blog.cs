namespace MattParkerDev.WebUI.Models;

public class Blog
{
    public required string Slug { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Content { get; set; }
    public required int Sequence { get; set; }
}
