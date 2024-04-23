using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EntityLayer.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        [Browsable(false)]
        public DateTime DateCreated { get; set; }
        [Browsable(false)]
        public DateTime? DateUpdated { get; set; }
        public string CategoryName { get; set; }
        //[Browsable(false)]
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
    }
}
