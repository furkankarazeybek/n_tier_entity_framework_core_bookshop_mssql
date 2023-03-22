using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
 
    public class FluentApi_Yazar
    {
    
        public int Yazar_Id { get; set; }

        public string YazarAd { get; set; }
 
        public string YazarSoyad { get; set; }
       
        public string Lokasyon { get; set; }

        public DateTime DogumTarihi { get; set; }

   
        public string AdSoyad
        {
            get 
            {
                return $"{YazarAd} {YazarSoyad}";
            }
        }

        public ICollection<FluentApi_KitapYazar> FluentApi_KitaplarYazarlar { get; set; }






    }
}
