using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YönetimProgramı
{  [Table("EldekiUrun")]
    class EldekiUrun
    {   [Key]
       public int ürünİd { get; set; }

        public  int ürünKod { get; set; }

        public  int ürünAdet { get; set; }

       public string üretici { get; set; }

    }
}
