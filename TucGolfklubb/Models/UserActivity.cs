﻿using System;

namespace TucGolfklubb.Models
{
    public class UserActivity
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public string Type { get; set; } = string.Empty; // e.g. "Post", "Reply"
        public string Content { get; set; } = string.Empty; // snippet or title
        public int? ForumPostId { get; set; } // Link to original post (optional)

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
