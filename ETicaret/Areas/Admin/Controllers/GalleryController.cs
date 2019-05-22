using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Areas.Admin.Model;
using ETicaret.DAL;
using ETicaret.ENT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class GalleryController : Controller
    {
        private readonly RepGallery _rep;
        private readonly ETicaretContext _db;
        private readonly ProductModel _model;
        private readonly RepCategories _repcat;
        private readonly RepProducts _reppro;
        private readonly GalleryModel _modelglr;
        public GalleryController(RepProducts reppro, RepGallery rep, ETicaretContext db, ProductModel model, RepCategories repcat, GalleryModel modelglr)
        {
            _rep = rep;
            _db = db;
            _model = model;
            _repcat = repcat;
            _reppro = reppro;
            _modelglr = modelglr;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Ekle()
        //{
        //    _model.CategoryDrop = _repcat.ComboDoldur(_model.CategoryDrop);
        //    return View(_model);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Ekle(IFormFile photo, ProductModel model)
        //{
        //    List<Gallery> glry = new List<Gallery>();
        //    _db.Entry(model.Products).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        //    if (photo == null || photo.Length == 0)
        //    {
        //        return Content("Resim Bulunamadı. Resimsiz Ürün Eklenemez.");
        //    }
        //    else
        //    {
        //        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/", photo.FileName);
        //        using (var stream = new FileStream(path, FileMode.Create))
        //        {
        //            await photo.CopyToAsync(stream);
        //        }
        //        model.Products.Image = photo.FileName;
        //        glry.Add(new Gallery
        //        {
        //            ProductId = model.Products.ProductId,
        //            Image = null,
        //        });
        //        foreach (var item in glry)
        //        {
        //            _rep.Add(item);
        //        }
        //        await _rep.Save();
        //        return RedirectToAction("ProductsListe", "Products");
        //    }
        //}
        //public IActionResult EkleCoklu()
        //{
        //    return View();
        //}
        public async Task<IActionResult> EkleCoklu(int id)
        {
            _model.Products = await _reppro.Find(id);
            return View(_model);
        }
        [HttpPost]
        public async Task<IActionResult> EkleCoklu(List<IFormFile> photo, ProductModel pm, int id)
        {
            List<Gallery> glry = new List<Gallery>();
            if (photo == null || photo.Count == 0)
            {
                return Content("Resim Bulunamadı");
            }
            else
            {
                foreach (var item in photo)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/", item.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    await item.CopyToAsync(stream);
                    glry.Add(new Gallery
                    {
                        ProductId = pm.Products.ProductId,
                        Image = item.FileName
                    });
                }
                foreach (var item in glry)
                {
                    _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            }
            await _rep.Save();
            return RedirectToAction("ProductsListe", "Products");
            //return RedirectToPage("Liste", "Gallery" + id);
        }

        [HttpGet]
        public IActionResult Liste(int id)
        {
            _modelglr.Glist = _rep.Liste(id);
            return View(_modelglr);
        }
    }
}