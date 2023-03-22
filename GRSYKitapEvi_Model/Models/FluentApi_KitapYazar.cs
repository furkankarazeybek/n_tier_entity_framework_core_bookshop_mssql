using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Model.Models
{
    public class FluentApi_KitapYazar
    {
  
        public int Kitap_Id { get; set; }

 
        public int Yazar_Id { get; set; }

       public FluentApi_Kitap Fluent_Kitap { get; set; }
       
       public FluentApi_Yazar Fluent_Yazar { get; set; } 

    
    }
}
