using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using contentapi.Models;

namespace contentapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : ControllerBase
    {
        private readonly ILogger<ContentController> _logger;

        public ContentController(ILogger<ContentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ContentModel> Get()
        {
            List<ContentModel> content = new List<ContentModel>();
            List<CommentModel> comments = new List<CommentModel>();
            comments.Add(new CommentModel
            {
                Author = "Jafet @jafetderivia",
                Comment = "K8s running on Azure",
                CreatedAt = DateTime.Now.Add(TimeSpan.FromHours(1))
            });
            content.Add(new ContentModel
            {
                Author = "Angel @angyay0",
                Content = "Orchestrator strategies are the best for today scalable solutions",
                CreatedAt = DateTime.Now,
                Comments = comments
            });

            return content;
        }
    }
}
