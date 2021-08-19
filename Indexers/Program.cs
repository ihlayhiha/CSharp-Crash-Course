using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Yella";
            System.Console.WriteLine(cookie["name"]);
            System.Console.WriteLine(cookie.Expiry);

            // StopWatch
            // var stopWatch = new StopWatch();
            // stopWatch.Start();
            // System.Console.WriteLine("Started the StopWatch.");
            // System.Console.WriteLine(stopWatch.Stop());
            // System.Console.WriteLine(stopWatch.Stop());


            // StackOverFlow
            var title = "FUCK THIS SHIT";
            var desc = $"This is the description of the StackOverFlow post with title: {title}";
            var post = new Post(title, desc);

            System.Console.WriteLine("Title: " +post.Title);
            System.Console.WriteLine("Description:\n" +post.Description);

            System.Console.WriteLine(post.Upvotes);
            System.Console.WriteLine(post.Downvotes);

            for (var  i = 0; i < 10; i++)
            {
                post.Downvote();
                for (var j = 0; j < 10; j++)                
                {
                    post.Upvote();
                }
            }
            System.Console.WriteLine(post.Upvotes);
            System.Console.WriteLine(post.Downvotes);

        }
    }
}
