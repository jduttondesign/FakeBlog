using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class PublishDraft
    {
        [Key]
        public int PublishID { get; set; }

        public int PublishDraftName { get; set; }

        public Author<Drafts>Drafts { get; set; }
    }
}