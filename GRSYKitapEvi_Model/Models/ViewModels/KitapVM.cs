using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRSYKitapEvi_Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GRSYKitapEvi_Model.Models.ViewModels
{
    public class KitapVM
    {
        public Kitap Kitap { get; set; }


        public IEnumerable<SelectListItem> YayınEviListesi { get; set; }


        public IEnumerable<SelectListItem> KategoriListesi { get; set; }

    }


}
