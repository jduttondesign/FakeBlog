using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FakeBlog.DAL
{
    public class FakeBlogContext : ApplicationDbContext
    {
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
    }
}