using System;
using System.ComponentModel;

namespace EntityLayer.Models
{
    public class OrderArticle
    {
        public int Id { get; set; }
        [Browsable(false)]
        public DateTime DateCreated { get; set; }
        [Browsable(false)]
        public DateTime? DateUpdated { get; set; }
        public int OrderId { get; set; }
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public int NumberOfArticle {  get; set; }
    }
}
