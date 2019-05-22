using ETicaret.DTO;
using ETicaret.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Areas.Admin.Model
{
    public class GalleryModel
    {
        public Gallery Gallery { get; set; }
        public ICollection<GalleryDTO> Glist { get; set; }
    }
}
