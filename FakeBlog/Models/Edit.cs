using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class Edit
    {
        [Key]
        public int EditID { get; set; }

        public int EditName { get; set; }

        public Author<Drafts>Drafts { get; set; }
    }
}