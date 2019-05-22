using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.ENT
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Unit { get; set; }
        public string Size { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categories Categories { get; set; }
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
    [Table("Gallery")]
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }

    }
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }

}
