using ETicaret.DTO;
using ETicaret.ENT;
using System.Collections.Generic;

namespace ETicaret.Areas.Admin.Model
{
    public class CategoriesModel
    {
        public Categories Category { get; set; }
        public ICollection<CategoriesDTO> CategoryList { get; set; }
    }
}
