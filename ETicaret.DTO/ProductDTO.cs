using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DTO
{
   public class ProductDTO
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public string unit { get; set; }
        public string size { get; set; }
        public decimal unitPrice { get; set; }
        public string categoryName { get; set; }
        public string image { get; set; }
        public int categoryId { get; set; }
    }
}
