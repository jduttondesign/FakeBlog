using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class DeletePost
    {
        [Key]
        public int DeletePostID { get; set; }

        public int DraftName { get; set; }

        public Author<Drafts>Drafts { get; set; }
    }
}