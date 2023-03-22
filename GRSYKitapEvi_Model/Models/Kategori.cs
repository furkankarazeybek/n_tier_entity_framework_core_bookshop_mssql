using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    //[Table("tb_Kategori")]
    public class Kategori
    {
        public int KategoriId { get; set; }

        [Column("Ad")]
        public string KategoriAd { get; set; }

        public List<Kitap> Kitap { get; set;  }
    }
}
