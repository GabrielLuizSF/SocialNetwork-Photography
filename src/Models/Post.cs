using System;

namespace Photography.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string UserEmail { get; set; }
        public string Message { get; set; }
        public string PhotoUrl { get; set; }

    }
}
