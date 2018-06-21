using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace crud_aspnet.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
    }
}