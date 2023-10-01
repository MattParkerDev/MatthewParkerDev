using MattParkerDev.WebUI.Models;

namespace MattParkerDev.WebUI.Services;

public static class BlogService
{
    private static readonly TimeSpan TimeZoneOffset = TimeSpan.FromHours(+10); // +10 = AEST
    private static readonly List<Blog> _blogs = new List<Blog>
    {
        new()
        {
            Sequence = 0,
            IsPublished = true,
            PublishedDate = new DateTimeOffset(2023, 08, 1, 9, 0, 0, TimeZoneOffset),
            Slug = "my-first-blog",
            Title = "My First Blog!",
            Description = "A demo blog.",
            PreviewImageUrl = "./_blogs/my-first-blog/image.avif"
        },
        new()
        {
            Sequence = 1,
            IsPublished = true,
            PublishedDate = new DateTimeOffset(2023, 10, 01, 8, 0, 0, TimeZoneOffset),
            Slug = "expecting-professionalism",
            Title = "Expecting Professionalism",
            Description = "I am your CTO, and these are my expectations of you.",
            PreviewImageUrl = "./_blogs/expecting-professionalism/image.avif"

        }
    };
    
    public static List<Blog> Blogs => _blogs.Where(x => x.IsPublished is true).OrderBy(x => x.Sequence).ToList();

    public static Blog? GetBlogBySlug(string slug)
    {
        return Blogs.FirstOrDefault(b => b.Slug == slug);
    }

    public static string GetBlogTitleBySlug(string slug)
    {
        return Blogs.Where(b => b.Slug == slug).Select(s => s.Title).First();
    }

    public static List<string> SlugList => Blogs.Select(b => b.Slug).ToList();
}
