using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    
    public class FluentApi_Kitap
    {
      

        public int Kitap_Id { get; set; }

     
        public string KitapAdı { get; set; }

        
        public double Fiyat { get; set; }

        public string ISBN { get; set; }

        public int KitapDetayIdForeign { get; set; }

        public FluentApi_KitapDetay FluentApi_KitapDetay { get; set; }

        public int YayinEviIdForeign { get; set; }
        public FluentApi_YayınEvi FluentApi_Yayinevi { get; set; } 

        public ICollection<FluentApi_KitapYazar> FluentApi_KitaplarYazarlar { get; set; }

    }
}
