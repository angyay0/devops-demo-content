using System;

namespace contentapi.Models 
{
    public class CommentModel
    {
        public string Author { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}