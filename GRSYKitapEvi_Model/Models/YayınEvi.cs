using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    //[Table("tb_YayinEvi")]
    public class YayınEvi
    {
        [Key]
        public int YayinEvi_Id { get; set; }
        [Required] 
        public string YayinEviAdi { get; set; }
        [Required]
        public string Lokasyon { get; set; }

        public List<Kitap> Kitap { get; set;  }




    }
}
