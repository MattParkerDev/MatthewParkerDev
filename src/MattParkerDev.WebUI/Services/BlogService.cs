using MattParkerDev.WebUI.Models;

namespace MattParkerDev.WebUI.Services;

public sealed class BlogService
{
    public static readonly List<Blog> Blogs = new List<Blog>
    {
        new()
        {
            Sequence = 0,
            Slug = "my-first-blog",
            Title = "My First Blog!",
            Description =
                "This is my first blog. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut."
        }
    };

    public static Blog? GetBlogBySlug(string slug)
    {
        return Blogs.FirstOrDefault(b => b.Slug == slug);
    }

    public static List<string> SlugList => Blogs.Select(b => b.Slug).ToList();
}
