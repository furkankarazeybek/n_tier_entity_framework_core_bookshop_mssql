using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    [Table("tb_Kitap")]
    public class Kitap
    {
        [Key]


        public int Kitap_Id { get; set; }

        [Required]
        public string KitapAdı { get; set; }

        [Required]
        public double Fiyat { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [ForeignKey("Kategori")]
       
        public int KategoriIdForeign { get; set; }
        public Kategori Kategori { get; set; }


        [ForeignKey("KitapDetay")]

        public int? KitapDetayIdForeign { get; set; }
        public KitapDetay KitapDetay { get; set; }

        [ForeignKey("YayınEvi")]

        public int YayınEviIdForeign { get; set; }
        public YayınEvi YayınEvi { get; set; }

        public ICollection<KitapYazar> KitaplarYazarlar { get; set; }
    }
}
