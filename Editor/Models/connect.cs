using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Editor.Models
{
    public partial class connect : DbContext
    {
        public connect()
            : base("name=connect")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.ArticleID)
                .IsFixedLength();

            modelBuilder.Entity<Article>()
                .Property(e => e.Author)
                .IsFixedLength();

            modelBuilder.Entity<Article>()
                .Property(e => e.Articlecontent)
                .IsFixedLength();
        }
    }
}
