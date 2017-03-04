using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.Models
{
    public class DeleteDraft
    {
        [Key]
        public int DeleteDraftID { get; set; }

        public int DraftName { get; set; }

        public Author<Drafts>Drafts { get; set; }
    }
}