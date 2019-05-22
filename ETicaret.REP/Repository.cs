using ETicaret.DAL;
using ETicaret.DTO;
using ETicaret.ENT;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.REP
{
    public class Repository
    {
        public class RepProducts : BaseRepository<Products>
        {
            public RepProducts(ETicaretContext db) : base(db)
            {

            }
            public ICollection<ProductDTO> Liste(int id)
            {
                return Set().Select(x => new ProductDTO
                {
                    id = x.ProductId,
                    productName = x.ProductName,
                    categoryName = x.Categories.CategoryName,
                    brand = x.Brand,
                    description = x.Description,
                    size = x.Size,
                    unit = x.Unit,
                    unitPrice = x.UnitPrice,
                    image = x.Image,
                    categoryId = x.CategoryId

                }).Where(x => x.categoryId == id).ToList();
            }


        }
        public class RepGallery : BaseRepository<Gallery>
        {
            public RepGallery(ETicaretContext db) : base(db)
            {

            }

            public ICollection<GalleryDTO> Liste(int id)
            {
                return Set().Select(x => new GalleryDTO
                {
                    imageId = x.Id,
                    productId = x.Products.ProductId,
                    image = x.Image,


                }).Where(x => x.productId == id).ToList();
            }
        }
        public class RepCategories : BaseRepository<Categories>
        {
            public RepCategories(ETicaretContext db) : base(db)
            {

            }
            public ICollection<CategoriesDTO> Liste()
            {
                return Set().Select(x => new CategoriesDTO
                {
                    id = x.CategoryId,
                    name = x.CategoryName
                }).ToList();
            }
            public List<SelectListItem> ComboDoldur(List<SelectListItem> item)
            {
                return item = Set().Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();

            }
        }
    }
}
