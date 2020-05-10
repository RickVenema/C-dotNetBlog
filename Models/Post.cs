using System;

namespace Blog.Models
{
    public class Post
    {
        public virtual Guid ID { get; set; } = Guid.NewGuid();
        public virtual String Title { get; set; }
        public virtual String Content { get; set; }
        public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual DateTime? LastUpdated { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual bool Deleted { get; set; } = false;
        public virtual bool NSFW { get; set; } = false;
    }
}