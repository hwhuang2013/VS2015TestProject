namespace MVCMovie.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class adoNetCodeFirstFromDB : DbContext
    {
        public adoNetCodeFirstFromDB()
            : base("name=adoNetCodeFirstFromDB")
        {
        }

        public virtual DbSet<BlogArticle集合> BlogArticle集合 { get; set; }
        public virtual DbSet<Blog集合> Blog集合 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog集合>()
                .HasMany(e => e.BlogArticle集合)
                .WithRequired(e => e.Blog集合)
                .HasForeignKey(e => e.Blog_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
