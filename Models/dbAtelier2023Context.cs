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

        //public DbSet<Personne> personnes { get; set; }
    }
}