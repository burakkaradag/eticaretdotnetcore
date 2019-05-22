using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.ENT;
using Microsoft.AspNetCore.Mvc;
using static ETicaret.REP.Repository;

namespace ETicaret.Controllers
{
    public class ProductsController : Controller
    {
        private readonly RepProducts _rep;
        public ProductsController(RepProducts rep)
        {
            _rep = rep;
        }

        public JsonResult Liste(int id)
        {
           var plist =  _rep.Liste(id);
            return Json(plist);
        }

        [HttpGet]
        public async Task<IActionResult> Detay(int id)
        {
            Products p = await _rep.Find(id);
            return Json(p);
        }
    }
}