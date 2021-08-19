using System;

namespace Indexers
{
    public class Post
    {
        public readonly string Title;
        public readonly string Description;
        public readonly DateTime Time;
        private int _upvotes;
        private int _downvotes;

        public int Upvotes{ get{return _upvotes;} }
        public int Downvotes{ get{return _downvotes;} }


        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Time = DateTime.Now;
            _upvotes = 0;
            _downvotes = 0;
        }

        public void Upvote()
        {
            _upvotes++;
        }

        public void Downvote()
        {
            _downvotes--;
        }

    }
}