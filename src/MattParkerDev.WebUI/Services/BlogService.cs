using MattParkerDev.WebUI.Models;

namespace MattParkerDev.WebUI.Services;

public static class BlogService
{
    private static readonly List<Blog> _blogs = new List<Blog>
    {
        new()
        {
            Sequence = 0,
            IsPublished = true,
            Slug = "my-first-blog",
            Title = "My First Blog!",
            Description =
                "This is my first blog. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut."
        },
        new()
        {
            Sequence = 1,
            IsPublished = false,
            Slug = "wip",
            Title = "Expecting Professionalism",
            Description =
                "This is my second blog. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut."
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
