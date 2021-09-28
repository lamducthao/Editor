namespace Editor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Article")]
    public partial class Article
    {
        [StringLength(10)]
        public string ArticleID { get; set; }

        [StringLength(10)]
        public string Author { get; set; }
        [AllowHtml]

        [StringLength(10)]
        public string Articlecontent { get; set; }
    }
}
