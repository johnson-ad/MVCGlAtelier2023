using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCGlAtelier2023.Models
{
    public class dbAtelier2023Context: DbContext
    {
        public dbAtelier2023Context() : base("connAtelier")
        {
        }

        public DbSet<Personne> personnes { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Gerant> gerants { get; set; }

        public System.Data.Entity.DbSet<MVCGlAtelier2023.Models.ClientViewModel> ClientViewModels { get; set; }
    }
}