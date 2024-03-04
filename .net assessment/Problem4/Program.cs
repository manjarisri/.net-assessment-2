using System;

namespace Problem4
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; }
        public int VoteCount { get; private set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreationDateTime = DateTime.Now;
            VoteCount = 0;
        }

        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new post
            Post post = new Post("stackoverflow post", "This post is about a .NET session, problem number 4.");

            // Upvote and downvote the post
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            // Display the current vote count
            Console.WriteLine("Current vote count: " + post.VoteCount);
        }
    }
}
