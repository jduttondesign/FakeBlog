using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class BlogPost
    {
        [Key]

        public int BlogPostId { get; set; }

        [Required]
        [MinLength(3)]
        public int Title { get; set; }
        public DateTime  DateCreated { get; set; } //required by default
        public DateTime PublishedAt { get; set; }
        public string Body { get; set; }
        public string Edited { get; set; }
        public bool IsDraft { get; set; }
        public string URL { get; set; }
    }
}