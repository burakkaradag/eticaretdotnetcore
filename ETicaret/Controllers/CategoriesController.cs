using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly RepCategories _rep;
        public CategoriesController(RepCategories rep)
        {
            _rep = rep;
        }
        public JsonResult Liste()
        {
            var glist = _rep.Liste();
            return Json(glist);
        }
    }
}