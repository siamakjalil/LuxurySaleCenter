using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class LuxurySaleCenterContext:DbContext
    {
      public DbSet<Admin> Admins { get; set; }
      public DbSet<Role> Roles { get; set; }

    }
}
