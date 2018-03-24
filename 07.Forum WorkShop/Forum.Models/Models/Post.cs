using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models.Models
{
    public class Post
    {
        public Post(int id, string title, string content, int categoryId, int authorId, IEnumerable<int> replays)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryId;
            this.AuthorId = authorId;
            this.Replays = new List<int> (replays);
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

        public ICollection<int> Replays { get; set; }
    }
}
