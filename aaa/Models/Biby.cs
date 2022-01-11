using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aaa.Models
{
    public class Biby
    {
        public int Id { get; set; }
        public string NomBiby { get; set; }
        public int isa
        {
            get;
            set;
        }
    }

    public class BibyDBContext : DbContext {
        public DbSet<Biby> Bibys { get; set; }
    }
}