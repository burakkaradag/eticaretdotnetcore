using ETicaret.DTO;
using ETicaret.ENT;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Areas.Admin.Model
{
    public class ProductModel
    {
        public Products Products { get; set; }
        public ICollection<ProductDTO> Plist { get; set; }
        public List<SelectListItem> CategoryDrop { get; set; }
        public List<Gallery> Glist { get; set; }
    }
}
