﻿using MattParkerDev.WebUI.Models;

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
        },
        new()
        {
            Sequence = 1,
            Slug = "my-second-blog",
            Title = "My Second Blog!",
            Description =
                "This is my second blog. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut."
        }
    };

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
