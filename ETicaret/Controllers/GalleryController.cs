using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Controllers
{
    public class GalleryController : Controller
    {
        private readonly RepGallery _rep;
        public GalleryController(RepGallery rep)
        {
            _rep = rep;
        }
        public JsonResult Liste(int id)
        {
            var glist = _rep.Liste(id);
            return Json(glist);
        }
    }
}