using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                InsertPost(db);
                
                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
        }

        static void InsertPost(BloggingContext db)
        {
            var firstBlog = db.Blogs.First();

            var post = new Post{ 
                Blog = firstBlog, 
                Title = "Hello World",
                Content = "Oh, hey.  I didn't see you there.  Hello world.",
                Comments = new List<Comment>
                {
                    new Comment
                    {
                        Content = "Right back at you.",
                    },
                },
            };

            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}
