using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aaa.Models
{
    public class Olona
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Nim { get; set; }
    }

    public class OlonaDBContext : DbContext {
        public DbSet<Olona> Olonas { get; set; }
    }
}