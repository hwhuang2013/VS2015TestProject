namespace MVCMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BlogArticle集合
    {
        public Guid Id { get; set; }

        public Guid BlogId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Guid Blog_Id { get; set; }

        public virtual Blog集合 Blog集合 { get; set; }
    }
}
