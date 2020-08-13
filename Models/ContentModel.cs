using System;
using System.Collections.Generic;

namespace contentapi.Models 
{
    public class ContentModel
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<CommentModel> Comments { get; set; }
    }

}