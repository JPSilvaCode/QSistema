using QSistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QSistema.Context
{
    public class LojaContext : DbContext
    {       
        public DbSet<Produto> Produto { get; set; }
    }
}