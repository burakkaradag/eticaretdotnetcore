using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Areas.Admin.Model;
using ETicaret.DAL;
using ETicaret.DTO;
using ETicaret.ENT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ProductModel _model;
        private readonly RepProducts _rep;
        private readonly ETicaretContext _db;
        private readonly RepGallery _repglr;
        private readonly RepCategories _repcat;
        public ProductsController(ProductModel model, RepProducts rep, ETicaretContext db, RepGallery repglr, RepCategories repCat)
        {
            _rep = rep;
            _model = model;
            _db = db;
            _repglr = repglr;
            _repcat = repCat;
        }

        public IActionResult ProductsListe()
        {

            _model.Plist = _db.Products.Select(x => new ProductDTO
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

            }).ToList();

            return View(_model);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            _model.CategoryDrop = _repcat.ComboDoldur(_model.CategoryDrop);
            return View(_model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Ekle(IFormFile photo, ProductModel model)
        {
            List<Gallery> glry = new List<Gallery>();
            _db.Entry(model.Products).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            if (photo == null || photo.Length == 0)
            {
                return Content("Resim Bulunamadı. Resimsiz Ürün Eklenemez.");
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "C:/Users/iau/Desktop/ProjeFatihBurak2ugrastıgım/ETicaretAngular/src/assets/images/", photo.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }
                model.Products.Image = photo.FileName;
                glry.Add(new Gallery
                {
                    ProductId = model.Products.ProductId,
                    Image = null,
                });
                foreach (var item in glry)
                {
                    _repglr.Add(item);
                }
                await _rep.Save();
                return RedirectToAction("ProductsListe", "Products");
            }
        }
    }
}