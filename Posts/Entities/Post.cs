using System;
using System.Text;
using Posts.Entities;

namespace Posts.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void RemotoComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.AppendLine(Title);
            bs.Append(Likes + " Likes - ");
            bs.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            bs.AppendLine(Content);
            bs.AppendLine("Comments: ");
            foreach(Comment c in comments)
            {
                bs.AppendLine(c.Text);
            }

            return bs.ToString();
        }
    }
}
