import { Component } from "solid-js";
import { Link } from "@solidjs/router";
import { Button } from "@suid/material";

const Blog: Component = () => {
  const posts = [
    { id: 1, title: "First Post", content: "This is my first blog post." },
    { id: 2, title: "Second Post", content: "This is my second blog post." },
    { id: 3, title: "Third Post", content: "This is my third blog post." },
  ];

  return (
    <div>
      <h1>Blog</h1>
      {posts.map((post) => (
        <div key={post.id}>
          <h2>{post.title}</h2>
          <p>{post.content}</p>
          <Link href={`/blog/${post.id}`}>Read More</Link>
        </div>
      ))}
      <Button>Click Me</Button>
    </div>
  );
};

export default Blog;
