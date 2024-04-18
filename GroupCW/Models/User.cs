using System.Runtime.InteropServices;

namespace GroupCW.models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }  // Consider using more secure methods for password storage
        // Additional user properties
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        // Additional blog properties
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int BlogId { get; set; }  // Foreign key from Blog
        // Additional comment properties
    }
}

