using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
namespace YönetimProgramı
{
    class VeriTabanı:DbContext
    {
        public DbSet<EldekiUrun> EldekiUrun { get; set; }
        
    }
}
