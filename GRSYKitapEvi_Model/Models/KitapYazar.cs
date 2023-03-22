using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    public class KitapYazar
    {
        [ForeignKey("Kitap")]
        public int Kitap_Id { get; set; }

        [ForeignKey("Yazar")]
        public int Yazar_Id { get; set; }

        public Kitap Kitap { get; set; }
        public Yazar Yazar { get; set; }
    }
}
