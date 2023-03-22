using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{

   
    public class FluentApi_KitapDetay
    {

        public int KitapDetay_Id { get; set; }

        public int BolumSayisi { get; set; }

        public int KitapSayfasi { get; set; }

        public double Agirlik { get; set; }

        public FluentApi_Kitap FluentApi_Kitap { get; set; }

    }
}
