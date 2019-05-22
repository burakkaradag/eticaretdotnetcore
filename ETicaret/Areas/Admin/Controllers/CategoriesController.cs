using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Areas.Admin.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly RepCategories _rep;
        private readonly CategoriesModel _model;
        public CategoriesController(RepCategories rep, CategoriesModel model)
        {
            _rep = rep;
            _model = model;
        }
        [HttpGet]
        public IActionResult Liste()
        {
            _model.CategoryList = _rep.Liste();
            return View(_model);
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Ekle(CategoriesModel cm)
        {
            _rep.Add(cm.Category);
            await _rep.Save();
            return RedirectToAction("Liste", "Categories");
        }
    }
}