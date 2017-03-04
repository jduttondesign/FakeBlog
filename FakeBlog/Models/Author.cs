using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        MaxLength[(60)]
        public string AuthorName { get; set; }

        MaxLength[(60)]
        public string AuthorEmail { get; set; }

        MaxLength[(60)]
        public string UserName { get; set; }

        MaxLength[(60)]
        public string PasswordHash { get; set; }

        public List<Post>Posts { get; set;}

    }
}